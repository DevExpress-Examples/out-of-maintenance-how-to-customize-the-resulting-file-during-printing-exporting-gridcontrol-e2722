using System;
using System.Drawing;
using DevExpress.XtraGrid;
using System.IO;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;

namespace WindowsApplication1
{
    public class GridExportHelper
    {
        private  GridControl _GridControl;
        MemoryStream layoutStream = new MemoryStream();


        public static void ExportGridControl(GridControl gc, string fileName)
        {

            new GridExportHelper().InternalExportGridControl(gc, fileName);
        }

        private GridView ExportedView
        {
            get
            {
                return _GridControl.MainView as GridView;
            }
        }
        private void InternalExportGridControl(GridControl gc, string fileName)
        {
            _GridControl = gc;
            try
            {
                LockUpdate();
                SaveLayout();
                SubscribeEvents(ExportedView);
                CustomizeGridViewBeforeExport(ExportedView);
                DoExport(fileName);
            }
            finally
            {
                UnsubscribeEvents(ExportedView);
                RestoreLayout();
                UnlockUpdate();
            }
        }

        private void LockUpdate()
        {
            _GridControl.BeginUpdate();

        }
        private void UnlockUpdate()
        {
            _GridControl.EndUpdate();
        }
        private void RestoreLayout()
        {
            layoutStream.Position = 0;
            ExportedView.RestoreLayoutFromStream(layoutStream, OptionsLayoutBase.FullLayout);
        }
        private void SaveLayout()
        {
            ExportedView.SaveLayoutToStream(layoutStream, OptionsLayoutBase.FullLayout);
        }

        private void CustomizeGridViewBeforeExport(GridView view)
        {
            view.OptionsView.ColumnAutoWidth = false;
            view.BestFitColumns();
            view.OptionsPrint.AutoWidth = false;
        }


        void view_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            e.DisplayText = String.Format("[{0}]", e.DisplayText);
        }

        private void SubscribeEvents(GridView view)
        {
            view.CustomColumnDisplayText += view_CustomColumnDisplayText;
        }
        private void UnsubscribeEvents(GridView view)
        {
            view.CustomColumnDisplayText -= view_CustomColumnDisplayText;
        }

        private void DoExport(string fileName)
        {
            _GridControl.ExportToXls(fileName);
        }
    }
}
