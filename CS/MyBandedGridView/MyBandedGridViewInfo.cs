using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid.Views.BandedGrid.ViewInfo;
using DevExpress.XtraGrid.Views.BandedGrid;

namespace MyXtraGrid
{
    public class MyBandedGridViewInfo : BandedGridViewInfo
    {
        public MyBandedGridViewInfo(DevExpress.XtraGrid.Views.BandedGrid.BandedGridView gridView)
            : base(gridView)
        {
            
        }
        protected override int CalcMinRowHeight()
        {
            return base.CalcMinRowHeight() + 10;
        }
    }
}
