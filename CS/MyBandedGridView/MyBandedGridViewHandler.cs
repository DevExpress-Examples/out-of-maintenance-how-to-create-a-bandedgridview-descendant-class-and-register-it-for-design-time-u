using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid.Views.BandedGrid.Handler;
using DevExpress.XtraGrid.Views.BandedGrid;
using System.Windows.Forms;

namespace MyXtraGrid
{
    public class MyBandedGridViewHandler : BandedGridHandler
    {
        public MyBandedGridViewHandler(DevExpress.XtraGrid.Views.BandedGrid.BandedGridView gridView)
            : base(gridView)
        {
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyData == Keys.Delete && View.State == BandedGridState.Normal)
                View.DeleteRow(View.FocusedRowHandle);
            if (e.KeyData == Keys.Enter && View.State == BandedGridState.Normal)
                View.AddNewRow();
        }
    }
}
