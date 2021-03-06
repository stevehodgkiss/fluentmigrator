using System;
using FluentMigrator.Builders.Create.Column;
using FluentMigrator.Builders.Create.ForeignKey;
using FluentMigrator.Builders.Create.Index;
using FluentMigrator.Builders.Create.Table;
using FluentMigrator.Infrastructure;

namespace FluentMigrator.Builders.Create
{
	public interface ICreateExpressionRoot : IFluentSyntax
	{
		ICreateTableWithColumnSyntax Table(string tableName);
		ICreateColumnOnTableSyntax Column(string columnName);
		ICreateForeignKeyFromTableSyntax ForeignKey();
		ICreateForeignKeyFromTableSyntax ForeignKey(string foreignKeyName);
		ICreateIndexForTableSyntax Index();
		ICreateIndexForTableSyntax Index(string indexName);
	}
}