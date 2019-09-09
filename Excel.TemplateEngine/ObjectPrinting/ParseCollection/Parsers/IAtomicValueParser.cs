﻿using System;

using Excel.TemplateEngine.ObjectPrinting.TableParser;

namespace Excel.TemplateEngine.ObjectPrinting.ParseCollection.Parsers
{
    public interface IAtomicValueParser
    {
        bool TryParse([NotNull] ITableParser tableParser, [NotNull] Type itemType, [CanBeNull] out object result);
    }
}