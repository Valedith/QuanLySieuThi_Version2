using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi_Version2.Infrastructures
{
    //This DataGridView prevent the Exception that your mouse accientally collide with
    //Top left header cell while auto Column size mode set to Fill
    class CustomDataGridView : DataGridView
    {
        protected override void OnHandleCreated(EventArgs e)
        {
            // Touching the TopLeftHeaderCell here prevents
            // System.InvalidOperationException:
            // This operation cannot be performed while
            // an auto-filled column is being resized.

            var topLeftHeaderCell = TopLeftHeaderCell;

            base.OnHandleCreated(e);
        }
    }
}
