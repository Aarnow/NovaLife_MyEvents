using Life.Network;
using Life.VehicleSystem;
using Mirror;
using System;
using UnityEngine;

namespace MyEvents
{
    public class Events
    {
        public virtual void Init(LifeServer server)
        {
            server.OnPlayerConnectEvent = (Action<Player>)Delegate.Combine(server.OnPlayerConnectEvent, new Action<Player>(OnPlayerConnect));
            server.OnPlayerDisconnectEvent = (Action<NetworkConnection>)Delegate.Combine(server.OnPlayerDisconnectEvent, new Action<NetworkConnection>(OnPlayerDisconnect));
            server.OnPlayerSpawnCharacterEvent = (Action<Player>)Delegate.Combine(server.OnPlayerSpawnCharacterEvent, new Action<Player>(OnPlayerSpawnCharacter));
            server.OnPlayerInputEvent = (Action<Player, KeyCode, bool>)Delegate.Combine(server.OnPlayerInputEvent, new Action<Player, KeyCode, bool>(OnPlayerInput));
            server.OnHourPassedEvent = (Action)Delegate.Combine(server.OnHourPassedEvent, new Action(OnHourPassed));
            server.OnMinutePassedEvent = (Action)Delegate.Combine(server.OnMinutePassedEvent, new Action(OnMinutePassed));
            server.OnPlayerMoneyEvent = (Action<Player, double, string>)Delegate.Combine(server.OnPlayerMoneyEvent, new Action<Player, double, string>(OnPlayerMoney));
            server.OnPlayerReceiveItemEvent = (Action<Player, int, int, int>)Delegate.Combine(server.OnPlayerReceiveItemEvent, new Action<Player, int, int, int>(OnPlayerReceiveItem));
            server.OnPlayerDropItemEvent = (Action<Player, int, int, int>)Delegate.Combine(server.OnPlayerDropItemEvent, new Action<Player, int, int, int>(OnPlayerDropItem));
            server.OnPlayerUseCommandEvent = (Action<Player, SChatCommand>)Delegate.Combine(server.OnPlayerUseCommandEvent, new Action<Player, SChatCommand>(OnPlayerUseCommand));
            server.OnPlayerBuyTerrainEvent = (Action<Player, int, double>)Delegate.Combine(server.OnPlayerBuyTerrainEvent, new Action<Player, int, double>(OnPlayerBuyTerrain));
            server.OnPlayerSellDrugsEvent = (Action<Player, int, int>)Delegate.Combine(server.OnPlayerSellDrugsEvent, new Action<Player, int, int>(OnPlayerSellDrugs));
            server.OnPlayerConsumeDrugEvent = (Action<Player>)Delegate.Combine(server.OnPlayerConsumeDrugEvent, new Action<Player>(OnPlayerConsumeDrug));
            server.OnPlayerDeathEvent = (Action<Player>)Delegate.Combine(server.OnPlayerDeathEvent, new Action<Player>(OnPlayerDeath));
            server.OnPlayerKillPlayerEvent = (Action<Player, Player>)Delegate.Combine(server.OnPlayerKillPlayerEvent, new Action<Player, Player>(OnPlayerKillPlayer));
            server.OnPlayerDamagePlayerEvent = (Action<Player, Player, int>)Delegate.Combine(server.OnPlayerDamagePlayerEvent, new Action<Player, Player, int>(OnPlayerDamagePlayer));
            server.OnPlayerChangeVehiclePlateEvent = (Action<Player, LifeVehicle, string, string>)Delegate.Combine(server.OnPlayerChangeVehiclePlateEvent, new Action<Player, LifeVehicle, string, string>(OnPlayerChangeVehiclePlate));
            server.OnPlayerChangeVehicleColorEvent = (Action<Player, LifeVehicle, string, string>)Delegate.Combine(server.OnPlayerChangeVehicleColorEvent, new Action<Player, LifeVehicle, string, string>(OnPlayerChangeVehicleColor));
        }

        public virtual void OnPlayerConnect(Player player)
        {
        }

        public virtual void OnPlayerSpawnCharacter(Player player)
        {
        }

        public virtual void OnPlayerDisconnect(NetworkConnection conn)
        {
        }

        public virtual void OnPlayerInput(Player player, KeyCode key, bool onUI)
        {
        }

        public virtual void OnHourPassed()
        {
        }

        public virtual void OnMinutePassed()
        {
        }

        public virtual void OnPlayerMoney(Player player, double amount, string reason)
        {
        }

        public virtual void OnPlayerReceiveItem(Player player, int itemId, int slotId, int number)
        {
        }

        public virtual void OnPlayerDropItem(Player player, int itemId, int slotId, int number)
        {
        }

        public virtual void OnPlayerUseCommand(Player player, SChatCommand command)
        {
        }

        public virtual void OnPlayerBuyTerrain(Player player, int terrainId, double price)
        {
        }

        public virtual void OnPlayerSellDrugs(Player player, int number, int price)
        {
        }

        public virtual void OnPlayerConsumeDrug(Player player)
        {
        }

        public virtual void OnPlayerDeath(Player player)
        {
        }

        public virtual void OnPlayerKillPlayer(Player killer, Player killed)
        {
        }

        public virtual void OnPlayerDamagePlayer(Player fromPlayer, Player toPlayer, int damage)
        {
        }

        public virtual void OnPlayerChangeVehiclePlate(Player player, LifeVehicle vehicle, string oldPlate, string newPlate)
        {
        }

        public virtual void OnPlayerChangeVehicleColor(Player player, LifeVehicle vehicle, string oldColor, string newColor)
        {
        }
    }
}
