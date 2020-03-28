using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstCrossXamarin.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
