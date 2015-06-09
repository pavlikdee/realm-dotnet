﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealmIO
{
    public interface ICoreProvider
    {
        bool HasTable(string tableName);
        void AddTable(string tableName);
        void AddColumnToTable(string tableName, string columnName, Type columnType);
        int InsertEmptyRow(string tableName);

        T GetValue<T>(string tableName, int rowIndex, string propertyName);
        void SetValue<T>(string tableName, int rowIndex, string propertyName, T value);
    }
}
