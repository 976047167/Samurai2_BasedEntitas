//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentLookupGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public static class ServiceComponentsLookup {

    public const int GameServiceEntitasInputService = 0;
    public const int GameServiceFindObjectService = 1;
    public const int GameServiceLoadService = 2;
    public const int GameServiceLogService = 3;
    public const int GameServiceTimerService = 4;

    public const int TotalComponents = 5;

    public static readonly string[] componentNames = {
        "GameServiceEntitasInputService",
        "GameServiceFindObjectService",
        "GameServiceLoadService",
        "GameServiceLogService",
        "GameServiceTimerService"
    };

    public static readonly System.Type[] componentTypes = {
        typeof(Game.Service.EntitasInputServiceComponent),
        typeof(Game.Service.FindObjectServiceComponent),
        typeof(Game.Service.LoadServiceComponent),
        typeof(Game.Service.LogServiceComponent),
        typeof(Game.Service.TimerServiceComponent)
    };
}
