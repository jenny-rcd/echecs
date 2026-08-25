# Jeu d'Échecs en C#

Un jeu d'échecs développé en C#. Le projet est actuellement en cours de développement : l'affichage console est fonctionnel et la transition vers une interface graphique (IHM) est la prochaine étape majeure.

> **Projet en cours de développement** — Les bases du projet sont posées, mais la logique des règles et l'interface graphique sont en cours d'implémentation.

---

## État du projet & Feuille de route

- [x] Affichage du plateau dans le terminal (Console C#)
- [ ] Migration vers une Interface Graphique multiplateforme (IHM Avalonia UI)
- [ ] Système de *Drag & Drop* pour déplacer les pièces
- [ ] Logique et règles de déplacement de chaque pièce
- [ ] Vérification et validation des coups légaux
- [ ] Détection de l'échec, du mat et du pat
- [ ] Gestion des coups spéciaux (Roque, Prise en passant, Promotion)
- [ ] Mode de jeu contre une IA

---

## Technologies utilisées

- **Langage** : C# (.NET)
- **Framework Graphique** : Avalonia UI (Compatible Windows, Linux, macOS)
- **IDE** : Visual Studio Code

---

## Architecture du projet

Le projet est structuré selon le patron de conception **MVC (Modèle-Vue-Contrôleur)** pour séparer strictement la logique du jeu de son rendu visuel :

- **Modèle** : Gestion des règles, de l'état du plateau et du déplacement des pièces.
- **Vue** : Affichage Console actuellement, conçu pour intégrer facilement une Interface Graphique (IHM) future.
- **Contrôleur** : Traitement des actions du joueur et mise à jour de l'état du jeu.

---

## Aperçu actuel (Console)

Rendu du plateau sous forme de grille ASCII dans le terminal :

```text
 --  --  --  --  --  --  --  --
| T | C | F | Q | K | F | C | T |
 --  --  --  --  --  --  --  --
| P | P | P | P | P | P | P | P |
 --  --  --  --  --  --  --  --
|   |   |   |   |   |   |   |   |
 --  --  --  --  --  --  --  --
|   |   |   |   |   |   |   |   |
 --  --  --  --  --  --  --  --
|   |   |   |   |   |   |   |   |
 --  --  --  --  --  --  --  --
|   |   |   |   |   |   |   |   |
 --  --  --  --  --  --  --  --
| P | P | P | P | P | P | P | P |
 --  --  --  --  --  --  --  --
| T | C | F | Q | K | F | C | T |
 --  --  --  --  --  --  --  --
```
Légende :

P : Pion | T : Tour | C : Cavalier | F : Fou | Q : Dame (Queen) | K : Roi (King)

## Installation et exécution

### Prérequis
- SDK .NET (version 6.0 ou supérieure recommandable)

### Lancement
1. **Cloner le projet**
   ```bash
   git clone git@github.com:jenny-rcd/echecs.git
   cd echecs
   ```
2. **lancer le projet**
   ```bash
   dotnet run
   ```
   
---
## Auteur

- **jenny-rcd** — Développeur principal — [*Profil GitHub*](https://github.com/jenny-rcd)

