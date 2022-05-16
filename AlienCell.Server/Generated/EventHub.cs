//
using MessagePipe;

namespace AlienCell.Generated.Events
{

public class EventHub : IEventHubPub, IEventHubSub
{

    public EventHub (EventFactory eventFactory)
    {
        (_artifact_added_pub, _artifact_added_sub) = eventFactory.CreateEvent<ArtifactAddedEvent>();
        (_artifact_retired_pub, _artifact_retired_sub) = eventFactory.CreateEvent<ArtifactRetiredEvent>();
        (_artifact_level_up_pub, _artifact_level_up_sub) = eventFactory.CreateEvent<ArtifactLevelUpEvent>();
        (_artifact_exp_change_pub, _artifact_exp_change_sub) = eventFactory.CreateEvent<ArtifactExpChangeEvent>();
        (_building_added_pub, _building_added_sub) = eventFactory.CreateEvent<BuildingAddedEvent>();
        (_building_retired_pub, _building_retired_sub) = eventFactory.CreateEvent<BuildingRetiredEvent>();
        (_hero_added_pub, _hero_added_sub) = eventFactory.CreateEvent<HeroAddedEvent>();
        (_hero_retired_pub, _hero_retired_sub) = eventFactory.CreateEvent<HeroRetiredEvent>();
        (_hero_level_up_pub, _hero_level_up_sub) = eventFactory.CreateEvent<HeroLevelUpEvent>();
        (_hero_exp_change_pub, _hero_exp_change_sub) = eventFactory.CreateEvent<HeroExpChangeEvent>();
        (_weapon_added_pub, _weapon_added_sub) = eventFactory.CreateEvent<WeaponAddedEvent>();
        (_weapon_retired_pub, _weapon_retired_sub) = eventFactory.CreateEvent<WeaponRetiredEvent>();
        (_weapon_level_up_pub, _weapon_level_up_sub) = eventFactory.CreateEvent<WeaponLevelUpEvent>();
        (_weapon_exp_change_pub, _weapon_exp_change_sub) = eventFactory.CreateEvent<WeaponExpChangeEvent>();
    }

    private ISubscriber<ArtifactAddedEvent> _artifact_added_sub;
    private IDisposablePublisher<ArtifactAddedEvent> _artifact_added_pub;
    private ISubscriber<ArtifactRetiredEvent> _artifact_retired_sub;
    private IDisposablePublisher<ArtifactRetiredEvent> _artifact_retired_pub;
    private ISubscriber<ArtifactLevelUpEvent> _artifact_level_up_sub;
    private IDisposablePublisher<ArtifactLevelUpEvent> _artifact_level_up_pub;
    private ISubscriber<ArtifactExpChangeEvent> _artifact_exp_change_sub;
    private IDisposablePublisher<ArtifactExpChangeEvent> _artifact_exp_change_pub;

    private ISubscriber<BuildingAddedEvent> _building_added_sub;
    private IDisposablePublisher<BuildingAddedEvent> _building_added_pub;
    private ISubscriber<BuildingRetiredEvent> _building_retired_sub;
    private IDisposablePublisher<BuildingRetiredEvent> _building_retired_pub;

    private ISubscriber<HeroAddedEvent> _hero_added_sub;
    private IDisposablePublisher<HeroAddedEvent> _hero_added_pub;
    private ISubscriber<HeroRetiredEvent> _hero_retired_sub;
    private IDisposablePublisher<HeroRetiredEvent> _hero_retired_pub;
    private ISubscriber<HeroLevelUpEvent> _hero_level_up_sub;
    private IDisposablePublisher<HeroLevelUpEvent> _hero_level_up_pub;
    private ISubscriber<HeroExpChangeEvent> _hero_exp_change_sub;
    private IDisposablePublisher<HeroExpChangeEvent> _hero_exp_change_pub;

    private ISubscriber<WeaponAddedEvent> _weapon_added_sub;
    private IDisposablePublisher<WeaponAddedEvent> _weapon_added_pub;
    private ISubscriber<WeaponRetiredEvent> _weapon_retired_sub;
    private IDisposablePublisher<WeaponRetiredEvent> _weapon_retired_pub;
    private ISubscriber<WeaponLevelUpEvent> _weapon_level_up_sub;
    private IDisposablePublisher<WeaponLevelUpEvent> _weapon_level_up_pub;
    private ISubscriber<WeaponExpChangeEvent> _weapon_exp_change_sub;
    private IDisposablePublisher<WeaponExpChangeEvent> _weapon_exp_change_pub;

    public IPublisher<ArtifactAddedEvent> ArtifactAddedPub { get => _artifact_added_pub; }
    public IPublisher<ArtifactRetiredEvent> ArtifactRetiredPub { get => _artifact_retired_pub; }
    public IPublisher<ArtifactLevelUpEvent> ArtifactLevelUpPub { get => _artifact_level_up_pub; }
    public IPublisher<ArtifactExpChangeEvent> ArtifactExpChangePub { get => _artifact_exp_change_pub; }


    public IPublisher<BuildingAddedEvent> BuildingAddedPub { get => _building_added_pub; }
    public IPublisher<BuildingRetiredEvent> BuildingRetiredPub { get => _building_retired_pub; }

    public IPublisher<HeroAddedEvent> HeroAddedPub { get => _hero_added_pub; }
    public IPublisher<HeroRetiredEvent> HeroRetiredPub { get => _hero_retired_pub; }
    public IPublisher<HeroLevelUpEvent> HeroLevelUpPub { get => _hero_level_up_pub; }
    public IPublisher<HeroExpChangeEvent> HeroExpChangePub { get => _hero_exp_change_pub; }


    public IPublisher<WeaponAddedEvent> WeaponAddedPub { get => _weapon_added_pub; }
    public IPublisher<WeaponRetiredEvent> WeaponRetiredPub { get => _weapon_retired_pub; }
    public IPublisher<WeaponLevelUpEvent> WeaponLevelUpPub { get => _weapon_level_up_pub; }
    public IPublisher<WeaponExpChangeEvent> WeaponExpChangePub { get => _weapon_exp_change_pub; }


    public ISubscriber<ArtifactAddedEvent> ArtifactAddedSub { get => _artifact_added_sub; }
    public ISubscriber<ArtifactRetiredEvent> ArtifactRetiredSub { get => _artifact_retired_sub; }
    public ISubscriber<ArtifactLevelUpEvent> ArtifactLevelUpSub { get => _artifact_level_up_sub; }
    public ISubscriber<ArtifactExpChangeEvent> ArtifactExpChangeSub { get => _artifact_exp_change_sub; }
    public ISubscriber<BuildingAddedEvent> BuildingAddedSub { get => _building_added_sub; }
    public ISubscriber<BuildingRetiredEvent> BuildingRetiredSub { get => _building_retired_sub; }
    public ISubscriber<HeroAddedEvent> HeroAddedSub { get => _hero_added_sub; }
    public ISubscriber<HeroRetiredEvent> HeroRetiredSub { get => _hero_retired_sub; }
    public ISubscriber<HeroLevelUpEvent> HeroLevelUpSub { get => _hero_level_up_sub; }
    public ISubscriber<HeroExpChangeEvent> HeroExpChangeSub { get => _hero_exp_change_sub; }
    public ISubscriber<WeaponAddedEvent> WeaponAddedSub { get => _weapon_added_sub; }
    public ISubscriber<WeaponRetiredEvent> WeaponRetiredSub { get => _weapon_retired_sub; }
    public ISubscriber<WeaponLevelUpEvent> WeaponLevelUpSub { get => _weapon_level_up_sub; }
    public ISubscriber<WeaponExpChangeEvent> WeaponExpChangeSub { get => _weapon_exp_change_sub; }
}

}
