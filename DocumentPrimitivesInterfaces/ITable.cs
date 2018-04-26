﻿using System.Collections.Generic;

using JetBrains.Annotations;

using SKBKontur.Catalogue.ExcelFileGenerator.Interfaces;
using SKBKontur.Catalogue.ExcelObjectPrinter.NavigationPrimitives;

namespace SKBKontur.Catalogue.ExcelObjectPrinter.DocumentPrimitivesInterfaces
{
    public interface ITable
    {
        ICell GetCell(ICellPosition position);
        ICell InsertCell(ICellPosition position);
        IEnumerable<ICell> SearchCellByText(string text);
        ITablePart GetTablePart(IRectangle rectangle);
        void ResizeColumn(int columnIndex, double width);
        IEnumerable<IRectangle> MergedCells { get; }
        IEnumerable<IColumn> Columns { get; }
        void MergeCells(IRectangle rectangle);
        void CopyFormControlsFrom([NotNull] ITable template);
        void CopyDataValidationsFrom([NotNull] ITable template);
        void CopyWorksheetExtensionListFrom([NotNull] ITable template);

        [CanBeNull]
        IExcelCheckBoxControlInfo TryGetCheckBoxFormControl([NotNull] string name);

        [CanBeNull]
        IExcelDropDownControlInfo TryGetDropDownFormControl([NotNull] string name);
    }
}