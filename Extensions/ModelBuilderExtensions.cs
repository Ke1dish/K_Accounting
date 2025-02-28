using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;

namespace K_Accounting.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void ApplyGlobalFilters<TInterface>(
            this ModelBuilder modelBuilder,
            Expression<Func<TInterface, bool>> expression)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                if (entityType.ClrType.GetInterface(typeof(TInterface).Name) != null)
                {
                    var newParam = Expression.Parameter(entityType.ClrType);
                    var newbody = ReplacingExpressionVisitor
                        .Replace(expression.Parameters.Single(), newParam, expression.Body);
                    modelBuilder.Entity(entityType.ClrType)
                        .HasQueryFilter(Expression.Lambda(newbody, newParam));
                }
            }
        }
    }
}
