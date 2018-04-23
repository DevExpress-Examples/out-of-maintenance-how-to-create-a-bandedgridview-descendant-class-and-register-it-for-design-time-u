using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.Handler;
using DevExpress.XtraGrid.Views.Base.ViewInfo;

namespace MyXtraGrid
{
    public class MyBandedGridViewInfoRegistrator : BandedGridInfoRegistrator
    {
        public override string ViewName { get { return "MyBandedGridView"; } }
        public override BaseView CreateView(GridControl grid) { return new MyBandedGridView(grid as GridControl); }
        public override BaseViewInfo CreateViewInfo(BaseView view) { return new MyBandedGridViewInfo(view as MyBandedGridView); }
        public override BaseViewHandler CreateHandler(BaseView view) { return new MyBandedGridViewHandler(view as MyBandedGridView); }
    }
}
