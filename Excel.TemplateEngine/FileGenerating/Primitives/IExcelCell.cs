﻿using SkbKontur.Excel.TemplateEngine.FileGenerating.DataTypes;

namespace SkbKontur.Excel.TemplateEngine.FileGenerating.Primitives
{
    public interface IExcelCell
    {
        IExcelCell SetNumericValue(double value);
        IExcelCell SetNumericValue(string value);
        IExcelCell SetNumericValue(decimal value);
        IExcelCell SetStringValue(string value);
        IExcelCell SetFormattedStringValue(FormattedStringValue value);
        IExcelCell SetFormula(string formula);
        IExcelCell SetStyle(ExcelCellStyle style);
        ExcelCellStyle GetStyle();

        string GetStringValue();
        ExcelCellIndex GetCellIndex();
    }
}