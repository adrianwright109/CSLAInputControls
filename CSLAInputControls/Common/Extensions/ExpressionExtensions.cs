using System.Linq.Expressions;

namespace CSLAInputControls.Common.Extensions
{
    public static class ExpressionExtensions
    {
        public static Expression<TDelegate> AndAlso<TDelegate>(this Expression<TDelegate> left, Expression<TDelegate> right)
        {
            return Expression.Lambda<TDelegate>(Expression.AndAlso(left, right), left.Parameters);
        }
    }
}
