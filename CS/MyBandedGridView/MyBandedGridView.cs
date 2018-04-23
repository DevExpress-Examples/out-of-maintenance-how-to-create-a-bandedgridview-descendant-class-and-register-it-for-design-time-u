using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid;

namespace MyXtraGrid
{
    public class MyBandedGridView : BandedGridView
    {
        public MyBandedGridView(DevExpress.XtraGrid.GridControl ownerGrid)
            : base(ownerGrid)
        {
            
        }
        public MyBandedGridView()
        {
            
        }
        protected override string ViewName { get { return "MyBandedGridView"; } }
    }
}
