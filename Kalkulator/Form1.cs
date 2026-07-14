using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        // ================= STATE KALKULATOR =================
        private string _currentInput = "0";
        private string _expressionText = "";
        private double _accumulator = 0;
        private string _pendingOperator = "";
        private bool _startNewInput = true;

        // ================= PALET WARNA (TEMA KALKULATOR STANDAR) =================
        // Terang, polos, dan familiar — mirip kalkulator bawaan Windows/HP.
        private static readonly Color ColorNumberBtn = Color.White;                     // tombol angka: putih
        private static readonly Color ColorFunctionBtn = Color.FromArgb(230, 230, 230); // C, CE, ⌫, ±, operator: abu muda
        private static readonly Color ColorEqualsBtn = Color.FromArgb(0, 103, 192);     // tombol "=": biru aksen
        private static readonly Color ColorTextDark = Color.Black;
        private static readonly Color ColorTextLight = Color.White;

        public Form1()
        {
            InitializeComponent();
            BuildKeypad();
            UpdateDisplay();
        }

        // Susunan tombol persis seperti kalkulator fisik: 4 kolom x 5 baris
        private void BuildKeypad()
        {
            string[,] layout =
            {
                { "C",  "CE", "⌫", "÷" },
                { "7",  "8",  "9", "×" },
                { "4",  "5",  "6", "−" },
                { "1",  "2",  "3", "+" },
                { "±",  "0",  ".", "=" }
            };

            const int startX = 15, startY = 165, w = 78, h = 70, gapX = 8, gapY = 8;

            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    string text = layout[row, col];

                    var btn = new Button
                    {
                        Text = text,
                        Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold),
                        FlatStyle = FlatStyle.Flat,
                        Size = new Size(w, h),
                        Location = new Point(startX + col * (w + gapX), startY + row * (h + gapY)),
                        Cursor = Cursors.Hand,
                        TabStop = false
                    };
                    btn.FlatAppearance.BorderSize = 0;
                    StyleButton(btn, text);
                    btn.Click += Key_Click;

                    this.Controls.Add(btn);
                }
            }
        }

        // Memberi warna sesuai jenis tombol — desain polos khas kalkulator biasa:
        // angka putih, fungsi & operator abu muda, hanya "=" yang diberi aksen warna.
        private void StyleButton(Button btn, string text)
        {
            switch (text)
            {
                case "=":
                    btn.BackColor = ColorEqualsBtn;
                    btn.ForeColor = ColorTextLight;
                    break;

                case "C":
                case "CE":
                case "⌫":
                case "±":
                case "÷":
                case "×":
                case "−":
                case "+":
                    btn.BackColor = ColorFunctionBtn;
                    btn.ForeColor = ColorTextDark;
                    break;

                default: // 0-9 dan titik desimal
                    btn.BackColor = ColorNumberBtn;
                    btn.ForeColor = ColorTextDark;
                    break;
            }
        }

        // ================= HANDLER TOMBOL =================
        private void Key_Click(object sender, EventArgs e)
        {
            if (!(sender is Button btn)) return;
            string key = btn.Text;

            switch (key)
            {
                case "C": Clear(); break;
                case "CE": ClearEntry(); break;
                case "⌫": Backspace(); break;
                case "±": ToggleSign(); break;
                case ".": InputDecimal(); break;
                case "=": Equals(); break;
                case "÷":
                case "×":
                case "−":
                case "+":
                    SetOperator(key);
                    break;
                default:
                    InputDigit(key);
                    break;
            }
        }

        // ================= LOGIKA KALKULATOR =================
        private void InputDigit(string digit)
        {
            if (_currentInput == "Error") Clear();

            if (_startNewInput)
            {
                _currentInput = digit;
                _startNewInput = false;
            }
            else
            {
                _currentInput = _currentInput == "0" ? digit : _currentInput + digit;
            }
            UpdateDisplay();
        }

        private void InputDecimal()
        {
            if (_currentInput == "Error") Clear();

            if (_startNewInput)
            {
                _currentInput = "0.";
                _startNewInput = false;
            }
            else if (!_currentInput.Contains('.'))
            {
                _currentInput += ".";
            }
            UpdateDisplay();
        }

        private void SetOperator(string op)
        {
            if (_currentInput == "Error") return;

            if (_pendingOperator != "" && !_startNewInput)
            {
                Calculate();
            }
            else
            {
                _accumulator = double.Parse(_currentInput, CultureInfo.InvariantCulture);
            }

            _pendingOperator = op;
            _expressionText = $"{FormatNumber(_accumulator)} {op}";
            _startNewInput = true;
            UpdateDisplay();
        }

        private void Calculate()
        {
            double current = double.Parse(_currentInput, CultureInfo.InvariantCulture);

            switch (_pendingOperator)
            {
                case "+": _accumulator += current; break;
                case "−": _accumulator -= current; break;
                case "×": _accumulator *= current; break;
                case "÷":
                    if (current == 0)
                    {
                        _currentInput = "Error";
                        _expressionText = "";
                        _pendingOperator = "";
                        _startNewInput = true;
                        UpdateDisplay();
                        return;
                    }
                    _accumulator /= current;
                    break;
            }
            _currentInput = FormatNumber(_accumulator);
        }

        private void Equals()
        {
            if (_pendingOperator == "" || _currentInput == "Error") return;

            _expressionText = $"{_expressionText} {_currentInput} =";
            Calculate();
            _pendingOperator = "";
            _startNewInput = true;
            UpdateDisplay();
        }

        private void Clear()
        {
            _currentInput = "0";
            _expressionText = "";
            _accumulator = 0;
            _pendingOperator = "";
            _startNewInput = true;
            UpdateDisplay();
        }

        private void ClearEntry()
        {
            _currentInput = "0";
            _startNewInput = true;
            UpdateDisplay();
        }

        private void Backspace()
        {
            if (_currentInput == "Error") { Clear(); return; }

            if (_currentInput.Length > 1)
                _currentInput = _currentInput.Substring(0, _currentInput.Length - 1);
            else
                _currentInput = "0";

            UpdateDisplay();
        }

        private void ToggleSign()
        {
            if (_currentInput == "Error" || _currentInput == "0") return;

            _currentInput = _currentInput.StartsWith("-")
                ? _currentInput.Substring(1)
                : "-" + _currentInput;

            UpdateDisplay();
        }

        private static string FormatNumber(double value)
        {
            return value.ToString("0.##########", CultureInfo.InvariantCulture);
        }

        private void UpdateDisplay()
        {
            lblResult.Text = _currentInput;
            lblExpression.Text = _expressionText;
        }
    }
}
