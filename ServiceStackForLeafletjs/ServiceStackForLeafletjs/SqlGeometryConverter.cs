using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack.OrmLite;
using System.Data;

namespace ServiceStackForLeafletjs
{
    public class SqlGeometryConverter:OrmLiteConverter
    {
        public override string ColumnDefinition
        {
            get { return "geometry"; }
        }

        public override DbType DbType
        {
            get { return DbType.Object; }
        }

    }
}