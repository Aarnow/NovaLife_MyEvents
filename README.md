![Nom de l'image](https://cdn.discordapp.com/attachments/517055230756782095/1188669168506109952/post-discord-myevents.png?ex=659b5d6e&is=6588e86e&hm=833461506bd6b1c1d6e55ebac6ca980d103c974e2803c4961b5a0eaed9490e84&)
# Novalife Plugin MyEvents

Le plugin Novalife MyEvents référence plusieurs événements que vous pourrez utiliser dans vos plugins respectifs.
D'autres événements peuvent s'ajouter à ce plugin avec le temps.

## Table des Matières

- [Installation](#installation)
- [Utilisation](#utilisation)
- [Droits de Propriété Intellectuelle](#droits-de-propriété-intellectuelle)

## Installation

1. Téléchargez le fichier `MyEvents.dll` depuis la page des releases de ce dépôt. 
2. Ajoutez le fichier `MyEvents.dll` dans le dossier des plugins de votre serveur Novalife.

## Utilisation

Le Plugin MyEvents doit être ajouté en tant que référence à votre projet.

```csharp
//	Créer une classe héritant de "Events"
//	Appeler les événements que vous souhaitez

public class YourClass : Events
{
    public override void OnPlayerSpawnCharacter(Player player)
    {
        base.OnPlayerSpawnCharacter(player);
        Debug.Log("Un joueur vient d'arriver en jeu !");
    }
}

//  Instancier votre classe contenant vos événements
//  Utiliser la fonction Init de votre instance lors de l'initialisation de votre plugin

public class Main : Plugin
{
    private readonly EventsTriggers Events;

    public Main(IGameAPI api): base(api)
    {
        Events = new EventsTriggers();
    }

    public override void OnPluginInit()
    {
        base.OnPluginInit();
        Events.Init(Nova.server);
    }
}
```

## Droits de Propriété Intellectuelle

Je vous demande simplement de respecter le temps que j'ai mis dans ce plugin.  
Merci de ne pas vous approprier le plugin, de ne pas le copier bêtement, et de ne pas faire des trucs étranges avec.

Pour discuter, contactez-moi sur discord: Aarnow  
Serveur discord: https://discord.gg/8j2suEE9Mf