using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PixelGridEditor
{
    public partial class Form1 : Form
    {
        private int GridSizeX = 10;
        private int GridSizeY = 10;
        private const int CellSize = 30;
        private Color[,] gridData;
        private Color colorEmpty = Color.FromArgb(249, 246, 240);
        private Color currentColor = Color.FromArgb(138, 154, 91);
        private Stack<Color[,]> undoStack = new Stack<Color[,]>();
        public Form1()
        {
            InitializeComponent();
            InitializeGrid();
            pbGrid.Paint += PbGrid_Paint;
            pbGrid.MouseClick += PbGrid_MouseClick;
            btnExport.Click += BtnExport_Click;
            btnReset.Click += btnReset_Click;
            btnResize.Click += btnResize_Click;
            btnSaveImage.Click += BtnSaveImage_Click;
        }
        private void InitializeGrid()
        {
            gridData = new Color[GridSizeX, GridSizeY];
            for (int x = 0; x < GridSizeX; x++)
            {
                for (int y = 0; y < GridSizeY; y++)
                {
                    gridData[x, y] = colorEmpty;
                }
            }
            undoStack.Clear();
            pbGrid.Invalidate();
        }
        private void PbGrid_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen gridPen = new Pen(Color.LightGray);
            for (int x = 0; x < GridSizeX; x++)
            {
                for (int y = 0; y < GridSizeY; y++)
                {
                    Rectangle cellRect = new Rectangle(x * CellSize, y * CellSize, CellSize, CellSize);
                    Brush cellBrush = new SolidBrush(gridData[x, y]);
                    g.FillRectangle(cellBrush, cellRect);
                    g.DrawRectangle(gridPen, cellRect);
                    cellBrush.Dispose();
                }
            }
            gridPen.Dispose();
        }
        private void PbGrid_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X / CellSize;
            int y = e.Y / CellSize;
            if (x >= 0 && x < GridSizeX && y >= 0 && y < GridSizeY)
            {
                SaveUndoState();
                if (rbPen.Checked)
                {
                    gridData[x, y] = currentColor;
                }
                else if (rbBucket.Checked)
                {
                    FloodFill(x, y, gridData[x, y], currentColor);
                }
                pbGrid.Invalidate();
                HitungLuasArea();
            }
        }
        private void HitungLuasArea()
        {
            int jumlahSelDiwarnai = 0;
            for (int x = 0; x < GridSizeX; x++)
            {
                for (int y = 0; y < GridSizeY; y++)
                {
                    if (gridData[x, y].ToArgb() != colorEmpty.ToArgb())
                    {
                        jumlahSelDiwarnai++;
                    }
                }
            }
            int luas = jumlahSelDiwarnai * (CellSize * CellSize);
            lblArea.Text = $"Luas Area: {luas} px² ({jumlahSelDiwarnai} sel)";
        }
        private void BtnExport_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for (int y = 0; y < GridSizeY; y++)
            {
                for (int x = 0; x < GridSizeX; x++)
                {
                    bool isFilled = gridData[x, y].ToArgb() != colorEmpty.ToArgb();
                    sb.Append(isFilled ? "1" : "0");
                }
                sb.AppendLine();
            }
            rtbExportResult.Text = sb.ToString();
        }
        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                currentColor = cd.Color;
            }
        }
        private void FloodFill(int startX, int startY, Color targetColor, Color replacementColor)
        {
            if (targetColor.ToArgb() == replacementColor.ToArgb()) return;
            Queue<Point> queue = new Queue<Point>();
            queue.Enqueue(new Point(startX, startY));
            while (queue.Count > 0)
            {
                Point p = queue.Dequeue();
                if (p.X < 0 | p.X >= GridSizeX | p.Y < 0 | p.Y >= GridSizeY) continue;
                if (gridData[p.X, p.Y]. ToArgb() == targetColor.ToArgb())
                {
                    gridData[p.X, p.Y] = replacementColor;
                    queue.Enqueue(new Point(p.X + 1, p.Y));
                    queue.Enqueue(new Point(p.X - 1, p.Y));
                    queue.Enqueue(new Point(p.X, p.Y + 1));
                    queue.Enqueue(new Point(p.X, p.Y - 1));
                }
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            InitializeGrid();
            HitungLuasArea();
            if (rtbExportResult != null)
            {
                rtbExportResult.Clear();
            }
        }
        private void btnResize_Click(object sender, EventArgs e)
        {
            GridSizeX = (int)nudWidth.Value;
            GridSizeY = (int)nudHeight.Value;
            InitializeGrid();
        }
        private void SaveUndoState()
        {
            Color[,] snapshot = new Color[GridSizeX, GridSizeY];
            Array.Copy(gridData, snapshot, gridData.Length);
            undoStack.Push(snapshot);
        }
        private void BtnUndo_Click(object sender, EventArgs e)
        {
            if (undoStack.Count > 0)
            {
                gridData = undoStack.Pop();
                pbGrid.Invalidate();
                HitungLuasArea();
            }
        }
        private void BtnSaveImage_Click(object sender, EventArgs e)
        {
            int width = GridSizeX * CellSize;
            int height = GridSizeY * CellSize;
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                for (int x = 0; x < GridSizeX; x++)
                {
                    for (int y = 0; y < GridSizeY; y++)
                    {
                        Rectangle rect = new Rectangle(x * CellSize, y * CellSize, CellSize, CellSize);
                        using (Brush brush = new SolidBrush(gridData[x, y]))
                        {
                            g.FillRectangle(brush, rect);
                        }
                        if (chkShowGrid.Checked)
                        {
                            using (Pen pen = new Pen(Color.LightGray)) { g.DrawRectangle(pen, rect); }
                        }
                    }
                }
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG Image|*.png|JPEG Image|*.jpg";
            sfd.Title = "Simpan Hasil Pixel Art Anda";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(sfd.FileName);
                MessageBox.Show("Gambar berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            bmp.Dispose();
        }
    }
}
