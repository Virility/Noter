using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Noter.Helpers;

namespace Noter.Controls
{
    public enum MouseState
    {
        Hover,
        Down,
        None
    }

    [DefaultEvent("TextChanged")]
    public sealed class NoterTextBox : Control
    {
        public event EventHandler EnterKeyPressed = delegate { };

        private readonly Pen _p1;
        private readonly SolidBrush _b1;
        private readonly TextBox _baseTextBox;

        private HorizontalAlignment _textAlign = HorizontalAlignment.Left;
        public HorizontalAlignment TextAlign
        {
            get { return _textAlign; }
            set
            {
                _textAlign = value;
                _baseTextBox.TextAlign = value;
            }
        }

        private int _maxLength = 32767;
        public int MaxLength
        {
            get { return _maxLength; }
            set
            {
                _maxLength = value;
                _baseTextBox.MaxLength = value;
            }
        }

        private bool _readOnly;
        public bool ReadOnly
        {
            get { return _readOnly; }
            set
            {
                _readOnly = value;
                _baseTextBox.ReadOnly = value;
            }
        }

        private bool _useSystemPasswordChar;
        public bool UseSystemPasswordChar
        {
            get { return _useSystemPasswordChar; }
            set
            {
                _useSystemPasswordChar = value;
                _baseTextBox.UseSystemPasswordChar = value;
            }
        }

        private bool _multiline;
        public bool Multiline
        {
            get { return _multiline; }
            set
            {
                _multiline = value;
                if (_baseTextBox == null)
                    return;

                _baseTextBox.Multiline = value;

                if (value)
                    _baseTextBox.Height = Height - 16;
                else
                {
                    Height = _baseTextBox.Height + 16;
                    Size = new Size(Size.Width, 35);
                }
            }
        }

        public override string Text
        {
            get { return base.Text; }
            set
            {
                base.Text = value;
                _baseTextBox.Text = value;
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            if (!Controls.Contains(_baseTextBox))
                Controls.Add(_baseTextBox);

            base.OnHandleCreated(e);
        }

        public NoterTextBox()
        {
            SetStyle((ControlStyles)139286, true);
            SetStyle(ControlStyles.Selectable, true);

            Font = new Font("Verdana", 10);
            ForeColor = Color.Black;
            Cursor = Cursors.IBeam;

            _p1 = Pens.Black;
            _b1 = new SolidBrush(Color.White);

            _baseTextBox = new TextBox
            {
                Font = Font,
                Text = Text,
                MaxLength = _maxLength,
                Multiline = _multiline,
                ReadOnly = _readOnly,
                UseSystemPasswordChar = _useSystemPasswordChar,
                ForeColor = ForeColor,
                BackColor = Color.White,
                BorderStyle = BorderStyle.None
            };

            if (_multiline)
                _baseTextBox.Height = Height - 16;
            else
                Height = _baseTextBox.Height + 16;

            _baseTextBox.TextChanged += OnBaseTextChanged;
            _baseTextBox.KeyDown += OnBaseKeyDown;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.Clear(BackColor);
            g.SmoothingMode = SmoothingMode.HighQuality;

            var borderRectangle = new Rectangle(0, 0, Width - 1, Height - 2);
            var roundedBorderPath = RoundRect.Round(borderRectangle, 2);

            g.DrawPath(_p1, roundedBorderPath);
            g.FillPath(_b1, roundedBorderPath);
        }

        #region "Misc Overrides"

        private void OnBaseTextChanged(object s, EventArgs e)
        {
            Text = _baseTextBox.Text;
        }

        private void OnBaseKeyDown(object s, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                _baseTextBox.SelectAll();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
                EnterKeyPressed(0, e);
        }

        protected override void OnResize(EventArgs e)
        {
            if (!_multiline)
                Size = new Size(Size.Width, 35);
            _baseTextBox.Location = new Point(8, 8);

            _baseTextBox.Width = Width - 16;
            _baseTextBox.Height = Height - 16;

            base.OnResize(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            _baseTextBox.Focus();
            base.OnMouseDown(e);
        }

        protected override void OnEnter(EventArgs e)
        {
            _baseTextBox.Focus();
            Invalidate();
            base.OnEnter(e);
        }

        protected override void OnLeave(EventArgs e)
        {
            Invalidate();
            base.OnLeave(e);
        }

        #endregion
    }
}
