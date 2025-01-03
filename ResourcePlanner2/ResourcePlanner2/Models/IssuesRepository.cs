using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnoBookRail.Common.Issues;

namespace ResourcePlanner.Models;
public class IssuesRepository
{
    private static List<Issue> issues = new List<Issue>();

    public static List<Issue> GetAllIssues()
        => issues;

    public static void AddIssue(Issue issue)
        => issues.Add(issue);
}
