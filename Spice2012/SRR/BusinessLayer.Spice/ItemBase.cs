using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace Disney.iDash.BusinessLayer
{
    public class ItemBase
    {
        public void LoadRow(DataRow row)
        {
            foreach (var pi in this.GetType().GetProperties())
            {
                if (row.Table.Columns.Contains(pi.Name))
                {
                    var value = row[pi.Name];
                    var defaultValue = row.Table.Columns[pi.Name].DefaultValue;
                    if (value == null)
                    {
                        if (defaultValue != null)
                            pi.SetValue(this, defaultValue, null);
                    }
                    else
                        pi.SetValue(this, value, null);
                }
            }
        }

        public void LoadRow(OleDbDataReader reader)
        {
            var schema = reader.GetSchemaTable();
            foreach (var pi in this.GetType().GetProperties())
            {
                if (schema.Select("ColumnName='" + pi.Name + "'").Length > 0)
                {
                    var value = reader.GetValue(reader.GetOrdinal(pi.Name));
                    if (value != null)
                        pi.SetValue(this, value, null);
                }
            }
        }
    }
}
