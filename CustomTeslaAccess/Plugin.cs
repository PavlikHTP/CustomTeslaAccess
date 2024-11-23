using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using System;
using Exiled.API.Enums;
using CustomTeslaAccess;

namespace CustomPlugin
{
    public class Plugin : Plugin<Config>
    {
        public override string Prefix => "Tesla";

        public override string Author => "pavlikHTP";

        public override string Name => "CustomTeslaAccess";

        public override Version Version => new Version(1, 0, 0);

        public override Version RequiredExiledVersion => new Version(8, 12, 0);

        public override PluginPriority Priority { get; } = PluginPriority.Default;

        public static Plugin Instance;

        public override void OnEnabled()
        {
            Instance = this;
            Exiled.Events.Handlers.Player.TriggeringTesla += OnTeslaTriggeringEv;

            Log.Debug($"{Name} has been enabled.");
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Instance = null;
            Exiled.Events.Handlers.Player.TriggeringTesla -= OnTeslaTriggeringEv;

            Log.Debug($"{Name} has been disabled.");
            base.OnDisabled();
        }

        public override void OnReloaded()
        {
            Exiled.Events.Handlers.Player.TriggeringTesla -= OnTeslaTriggeringEv;
            Exiled.Events.Handlers.Player.TriggeringTesla += OnTeslaTriggeringEv;

            base.OnReloaded();
        }

        private static void OnTeslaTriggeringEv(TriggeringTeslaEventArgs ev)
        {
            Player player = ev.Player;

            if(
                   player.HasItem(ItemType.KeycardContainmentEngineer) ||
                   player.HasItem(ItemType.KeycardFacilityManager) ||
                   player.HasItem(ItemType.KeycardGuard) ||
                   player.HasItem(ItemType.KeycardJanitor) ||
                   player.HasItem(ItemType.KeycardO5) ||
                   player.HasItem(ItemType.KeycardScientist) ||
                   player.HasItem(ItemType.KeycardZoneManager) ||
                   player.HasItem(ItemType.KeycardResearchCoordinator) ||
                   player.HasItem(ItemType.KeycardMTFCaptain) ||
                   player.HasItem(ItemType.KeycardMTFOperative) ||
                   player.HasItem(ItemType.KeycardMTFPrivate)
              )
                ev.IsTriggerable = false;
            else
                ev.IsTriggerable = true;
        }


    }
}