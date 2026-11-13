namespace RaftHarbor.Core;

/// <summary>Research milestones only; no game integration is implemented.</summary>
public static class InvestigationPlan
{
    public static IReadOnlyList<string> Milestones { get; } = Array.AsReadOnly(new[]
    {
        "Record game, Unity, Steam, loader, and assembly versions on a licensed test host.",
        "Validate loader callbacks and networking APIs with a logging-only mod.",
        "Map world loading, host simulation, player dependencies, and Steam session lifetime.",
        "Attempt explicit opt-in server mode on a disposable world; connect a second client.",
        "Verify empty-server simulation, save/restart/rejoin, and clean shutdown."
    });
}
