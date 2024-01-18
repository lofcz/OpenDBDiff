using OpenDBDiff.Abstractions.Schema.Model;
using System;
using System.Collections.Generic;

namespace OpenDBDiff.SqlServer.Schema.Options
{
    public class SqlOptionScript : IOptionsContainer<object>
    {
        public SqlOptionScript()
        {
        }

        public bool AlterObjectOnSchemaBinding { get; set; } = true;
        public string DiffHeader { get; set; }

        public SqlOptionScript(IOptionsContainer<object> optionsContainer)
        {
            AlterObjectOnSchemaBinding = (bool)optionsContainer.GetOptions()["AlterObjectOnSchemaBinding"];
            DiffHeader = (string)optionsContainer.GetOptions()["DiffHeader"];
        }

        public IDictionary<string, object> GetOptions()
        {
            return new Dictionary<string, object>
            {
                { "AlterObjectOnSchemaBinding", AlterObjectOnSchemaBinding },
                { "DiffHeader", DiffHeader },
            };
        }
    }
}
