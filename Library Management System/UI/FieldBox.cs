using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class FieldBox : UserControl
    {
        public enum FieldBoxType
        {
            Label = 0,
            TextBox = 1,
            ComboBox = 2
        }
        AutoCompleteStringCollection _autoCompleteList;

        private FieldBoxType _activeFieldType;

        private FieldBoxType _editFieldType;
        public FieldBoxType EditFieldType
        {
            get
            {
                return
                    _editFieldType;
            }
            set
            {
                _editFieldType = value;
            }
        }

        private FieldBoxType _displayFieldType;
        public FieldBoxType DisplayFieldType
        {
            get
            {
                return _displayFieldType;
            }
            set
            {
                _displayFieldType = value;
            }
        }

        private void changeFieldType(FieldBoxType value)
        {
            if (tlpFieldBox.Controls.Contains(_valueControl))
                tlpFieldBox.Controls.Remove(_valueControl);


            switch (value)
            {
                case FieldBoxType.Label:
                    _valueControl = new Label();
                    break;
                case FieldBoxType.TextBox:
                    _valueControl = new TextBox();
                    break;
                case FieldBoxType.ComboBox:
                    _valueControl = new ComboBox();
                    break;
            }



            if (!tlpFieldBox.Controls.Contains(_valueControl))
                tlpFieldBox.Controls.Add(_valueControl, 1, 0);

            useDataSource();
            _valueControl.Text = _value;

        }

        private Control _valueControl;
        private string _value;
        public object Value
        {
            get
            {
                if (_valueControl is ComboBox)
                    return (_valueControl as ComboBox).SelectedValue;
                else
                    return _valueControl.Text;
                
            }
        }
        public string ToValueString()
        {
            return Value.ToString();
        }

        public FieldBox()
        {
            InitializeComponent();
            DisplayFieldType = FieldBoxType.Label; //Default        
            EditFieldType = FieldBoxType.TextBox;
            _activeFieldType = DisplayFieldType;

            _valueControl = new Control();
            _valueControl.Name = "valueControl";
            _valueControl.TextChanged += new EventHandler(_valueControl_TextChanged);

        }

        void _valueControl_TextChanged(object sender, EventArgs e)
        {
            _value = (sender as Control).Text;
        }

        public string LabelText
        {
            get
            {
                return lblLabel.Text;
            }
            set
            {
                lblLabel.Text = value;
            }
        }
        public override string Text
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                _valueControl.Text = value;
            }
        }

        #region DataSource
        private object _dataSource;
        public object DataSource
        {
            get
            {
                return _dataSource;
            }
            set
            {
                _dataSource = value;
                useDataSource();
            }
        }
        private void useDataSource()
        {
            if (_dataSource != null)
            {
                if (_autoCompleteList == null)
                {
                    _autoCompleteList = new AutoCompleteStringCollection();
                    foreach (object obj in _dataSource as IEnumerable<object>)
                        _autoCompleteList.Add(obj.ToString());
                }



                if (_valueControl is TextBox)
                {
                    TextBox textBox = (_valueControl as TextBox);
                    if (textBox.AutoCompleteCustomSource == null)
                    {
                        textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        textBox.AutoCompleteCustomSource = _autoCompleteList;
                    }
                }
                else if (_valueControl is ComboBox)
                {
                    ComboBox comboBox = _valueControl as ComboBox;
                    if (comboBox.DataSource == null || comboBox.AutoCompleteCustomSource == null)
                    {
                        comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        comboBox.AutoCompleteCustomSource = _autoCompleteList;
                        comboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        comboBox.DataSource = _dataSource;
                    }
                }



                ComboBox combo = new ComboBox();
                TextBox txt = new TextBox();
                Label lbl = new Label();
            }
        }
        #endregion

        private bool _editMode;
        public bool EditMode
        {
            set
            {

                if (value)
                {
                    changeFieldType(EditFieldType);
                    useDataSource();
                }
                else
                    changeFieldType(DisplayFieldType);

                _editMode = value;
            }
            get
            {
                return _editMode;

            }
        }

        private void FieldBox_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
