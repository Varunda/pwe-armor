﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using watchtower.Constants;
using watchtower.Models;
using watchtower.Models.Events;

namespace watchtower.Services {

    public interface IEventBroadcastService {

        event EventHandler<Ps2EventArgs<string>>? OnTestEvent;
        void EmitTestEvent(string msg);

        event EventHandler<Ps2EventArgs<KillEvent>>? OnKillEvent;
        void EmitKillEvent(KillEvent ev);

        event EventHandler<Ps2EventArgs<ExpEvent>>? OnExpEvent;
        void EmitExpEvent(ExpEvent ev);

        event EventHandler<Ps2EventArgs<FacilityControlEvent>> OnFacilityControlEvent;
        void EmitFacilityControlEvent(FacilityControlEvent ev);

        event EventHandler<Ps2EventArgs<ItemAddedEvent>> OnItemAddedEvent;
        void EmitItemAddedEvent(ItemAddedEvent ev);

        event EventHandler<Ps2EventArgs<int>> OnTimerEvent;
        void EmitTimerEvent(int time);

        event EventHandler<Ps2EventArgs<BastionTickArgs>> OnBastionTimerEvent;
        void EmitBastionTimerEvent(int index, int lifespan);

        event EventHandler<Ps2EventArgs<TrackedPlayer?>> OnPlayerUpdateEvent;
        void EmitPlayerUpdateEvent(int index, TrackedPlayer? p1);

        event EventHandler<Ps2EventArgs<MatchState>> OnMatchStateEvent;
        void EmitMatchStateEvent(MatchState state);

        event EventHandler<Ps2EventArgs<MatchSettings>> OnMatchSettingsEvent;
        void EmitMatchSettingsEvent(MatchSettings settings);

        event EventHandler<Ps2EventArgs<VehicleDestroyEvent>> OnVehicleDestroy;
        void EmitVehicleDestroyEvent(VehicleDestroyEvent ev);

    }
}
