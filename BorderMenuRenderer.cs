using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
    internal class BorderMenuRenderer : ToolStripRenderer

    {
        private readonly int cornerRadius = 3;
        private readonly int itemSpacing = 5; // khoảng cách giữa các mục

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, e.Item.Width - 1, e.Item.Height - 1);

            // Padding khoảng cách 5px giữa các menu item
            rect.Inflate(-itemSpacing / 2, 0);

            using (GraphicsPath path = CreateRoundedRectangle(rect, cornerRadius))
            using (Brush fill = new SolidBrush(Color.LightSteelBlue)) // Màu khung
            using (Pen border = new Pen(Color.LightSteelBlue, 1))
            {
                g.FillPath(fill, path);
                g.DrawPath(border, path);
            }
        }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            e.TextColor = Color.Black; // Chữ màu đen
            base.OnRenderItemText(e);
        }

        private GraphicsPath CreateRoundedRectangle(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
    }
