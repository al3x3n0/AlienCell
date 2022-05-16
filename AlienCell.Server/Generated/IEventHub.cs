//
using MessagePipe;

namespace AlienCell.Generated.Events
{

public interface IEventHubSub
{
    ISubscriber<ArtifactAddedEvent> ArtifactAddedSub { get; }
    ISubscriber<ArtifactRetiredEvent> ArtifactRetiredSub { get; }
    ISubscriber<ArtifactLevelUpEvent> ArtifactLevelUpSub { get; }
    ISubscriber<ArtifactExpChangeEvent> ArtifactExpChangeSub { get; }

    ISubscriber<BuildingAddedEvent> BuildingAddedSub { get; }
    ISubscriber<BuildingRetiredEvent> BuildingRetiredSub { get; }

    ISubscriber<HeroAddedEvent> HeroAddedSub { get; }
    ISubscriber<HeroRetiredEvent> HeroRetiredSub { get; }
    ISubscriber<HeroLevelUpEvent> HeroLevelUpSub { get; }
    ISubscriber<HeroExpChangeEvent> HeroExpChangeSub { get; }

    ISubscriber<WeaponAddedEvent> WeaponAddedSub { get; }
    ISubscriber<WeaponRetiredEvent> WeaponRetiredSub { get; }
    ISubscriber<WeaponLevelUpEvent> WeaponLevelUpSub { get; }
    ISubscriber<WeaponExpChangeEvent> WeaponExpChangeSub { get; }

}

public interface IEventHubPub
{
    IPublisher<ArtifactAddedEvent> ArtifactAddedPub { get; }
    IPublisher<ArtifactRetiredEvent> ArtifactRetiredPub { get; }
    IPublisher<ArtifactLevelUpEvent> ArtifactLevelUpPub { get; }
    IPublisher<ArtifactExpChangeEvent> ArtifactExpChangePub { get; }

    IPublisher<BuildingAddedEvent> BuildingAddedPub { get; }
    IPublisher<BuildingRetiredEvent> BuildingRetiredPub { get; }
    IPublisher<HeroAddedEvent> HeroAddedPub { get; }
    IPublisher<HeroRetiredEvent> HeroRetiredPub { get; }
    IPublisher<HeroLevelUpEvent> HeroLevelUpPub { get; }
    IPublisher<HeroExpChangeEvent> HeroExpChangePub { get; }

    IPublisher<WeaponAddedEvent> WeaponAddedPub { get; }
    IPublisher<WeaponRetiredEvent> WeaponRetiredPub { get; }
    IPublisher<WeaponLevelUpEvent> WeaponLevelUpPub { get; }
    IPublisher<WeaponExpChangeEvent> WeaponExpChangePub { get; }

}

}
