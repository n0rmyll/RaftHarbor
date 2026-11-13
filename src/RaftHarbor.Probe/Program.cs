using RaftHarbor.Core;

if (args.Length != 1 || args[0] != "--plan")
{
    Console.Error.WriteLine("Usage: RaftHarbor.Probe --plan");
    Console.Error.WriteLine("Research checklist only. No game integration or server is implemented.");
    return 2;
}

Console.WriteLine("RaftHarbor: investigation scaffold; NOT a working dedicated server.");
foreach (var milestone in InvestigationPlan.Milestones)
    Console.WriteLine($"- {milestone}");
return 0;
