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
        #region "Public Declares"

        public event EventHandler EnterKeyPressed = delegate { };

        private Pen RegBorder;
        private SolidBrush RegBG;
        private Rectangle CBounds;
        private GraphicsPath RoundedRec;
        private Graphics G;

        private HorizontalAlignment _textAlign = HorizontalAlignment.Left;
        private int _maxLength = 32767;
        private bool _readOnly;
        private bool _useSystemPasswordChar;
        private bool _multiline;
        public TextBox Base;

        public HorizontalAlignment TextAlign
        {
            get { return _textAlign; }
            set
            {
                _textAlign = value;
                if (Base != null)
                    Base.TextAlign = value;
            }
        }

        public int MaxLength
        {
            get { return _maxLength; }
            set
            {
                _maxLength = value;
                if (Base != null)
                    Base.MaxLength = value;
            }
        }

        public bool ReadOnly
        {
            get { return _readOnly; }
            set
            {
                _readOnly = value;
                if (Base != null)
                    Base.ReadOnly = value;
            }
        }

        public bool UseSystemPasswordChar
        {
            get { return _useSystemPasswordChar; }
            set
            {
                _useSystemPasswordChar = value;
                if (Base != null)
                    Base.UseSystemPasswordChar = value;
            }
        }

        public bool Multiline
        {
            get { return _multiline; }
            set
            {
                _multiline = value;
                if (Base == null)
                    return;

                Base.Multiline = value;

                if (value)
                    Base.Height = Height - 16;
                else
                {
                    Height = Base.Height + 16;
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
                if (Base != null)
                    Base.Text = value;
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            if (!Controls.Contains(Base))
                Controls.Add(Base);

            base.OnHandleCreated(e);
        }

        #endregion

        public NoterTextBox()
        {
            SetStyle((ControlStyles)139286, true);
            SetStyle(ControlStyles.Selectable, true);

            Font = new Font("Segoe UI", 10);
            ForeColor = Color.Black;
            Cursor = Cursors.IBeam;

            Base = new TextBox
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
                Base.Height = Height - 16;
            else
                Height = Base.Height + 16;

            Base.TextChanged += OnBaseTextChanged;
            Base.KeyDown += OnBaseKeyDown;

            RegBorder = Pens.Black;
            RegBG = new SolidBrush(Color.White);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            G = pevent.Graphics;
            G.SmoothingMode = SmoothingMode.HighQuality;
            CBounds = new Rectangle(0, 0, Width - 1, Height - 2);
            RoundedRec = RoundRect.Round(CBounds, 2);

            G.Clear(BackColor);
            G.DrawPath(RegBorder, RoundedRec);
            G.FillPath(RegBG, RoundedRec);
        }

        #region "Misc Overrides"

        private void OnBaseTextChanged(object s, EventArgs e)
        {
            Text = Base.Text;
        }

        private void OnBaseKeyDown(object s, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                Base.SelectAll();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
                EnterKeyPressed(0, e);
        }

        protected override void OnResize(EventArgs e)
        {
            if (!_multiline)
                Size = new Size(Size.Width, 35);
            Base.Location = new Point(8, 8);

            Base.Width = Width - 16;
            Base.Height = Height - 16;

            base.OnResize(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            Base.Focus();
            base.OnMouseDown(e);
        }

        protected override void OnEnter(EventArgs e)
        {
            Base.Focus();
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