using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bug_Tracker.ClassLib.Access.SQL
{
    public class DataAccess
    {
        public ModelBug CreateBug(ModelBug model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionStringHelper.ConnectionValue("BugTracker")))
            {
                var p = new DynamicParameters();

                p.Add("@BugProductName", model.BugProductName);
                p.Add("@BugDescription", model.BugDescription);
                p.Add("@BugText", model.BugText);
                p.Add("@BugReportedVersion", model.BugReportedVersion);
                p.Add("@BugWhenReported", model.BugWhenReported);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spBug_Insert", p, commandType: CommandType.StoredProcedure);

                model.BugID = p.Get<int>("@id");

                return model;
            }
        }

        public List<ModelBug> GetBugs(string product)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionStringHelper.ConnectionValue("BugTracker")))
            {
                return connection.Query<ModelBug>($"SELECT * FROM Bug WHERE BugProductName = '{ product }'").ToList();
            }
        }
    }
}