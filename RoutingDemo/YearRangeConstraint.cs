using Microsoft.AspNetCore.Routing;
using System;

public class YearRangeConstraint : IRouteConstraint
{
    public bool Match(
        HttpContext httpContext,
        IRouter router,
        string routeKey,
        RouteValueDictionary values,
        RouteDirection routeDirection)
    {
        // Get the 'year' value from the route values
        if (values.TryGetValue(routeKey, out var value) && value is string yearString)
        {
            if (int.TryParse(yearString, out int year))
            {
                // Get the current year
                int currentYear = DateTime.Now.Year;

                // Check if the year is within the range of 1900 and current year
                return year >= 1900 && year <= currentYear;
            }
        }

        return false;
    }
}
