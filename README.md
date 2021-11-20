# Doodle-Jump-Unity

Projet EVHI 2021-2022

**Projet en binôme : Damien Legros, Petar Calic et Cédric Cornède

Projet de développement d'un jeu vidéo du type **doodle jump** avec le moteur de jeu *Unity* au cours du master 2 ANDROIDE de septembre à octobre 2021 dans le cadre de l'UE EVHI.

**Encadrement du projet : Nathan Bardin

Le projet consiste à développer les éléments suivants :

- Un menu principal, avec un bouton “Jouer”, et un bouton “Quitter”
- une boucle complète du jeu (c'est-à-dire, du menu, puis le jeu en lui-même, et le
retour au menu quand on perd).
- Un score atteint par le joueur, visible tout le temps, et à la fin du jeu
- Un personnage jouable avec :
   - des animations : une animation idle (quand il ne se passe rien), de quand il saute (il plie ses petites jambes), et de quand il tire à la verticale (pas besoin de la version quand il tire en diagonale).
   - des déplacements horizontaux contrôlables avec les touches “flèche de gauche” et “flèche de droite”
   - des sauts dès qu’il touche une plateforme, ou un ennemi par dessus.
   - une téléportation quand il sort de la zone de jeu horizontalement, pour réapparaître de l’autre côté de l’écran
   - qui déclenche la fin du jeu si il sort de la zone de jeu par le bas
   - (Optionnel) la possibilité de tirer au dessus de soi pour détruire des ennemis en appuyant sur la “flèche du haut” ou espace
- Une caméra qui ne peut que monter
- Des plateformes qui apparaissent quand le joueur monte :
   - Des plateformes vertes, fixes
   - Des plateformes bleues, qui bougent de manière horizontale sur tout l’écran
   - Des plateformes marron, qui se cassent quand le personnage-joueur les touche
- Des obstacles :
   - des trous noirs qui déclenchent la fin du jeu si le joueur les touche
   - des ennemis qui déclenchent aussi la fin du jeu si le joueur les touche.
   - (Optionnel) le joueur peut tirer dessus ou tomber dessus pour s’en débarrasser
- D’objets bonus qui aident à monter :
   - des ressorts qui font sauter beaucoup plus haut le joueur s’il tombe dessus
   - (Optionnel) des hélico-chapeaux qui l’aident à monter, puis disparaît
   - (Optionnel) des jet-packs, qui font comme les hélico-chapeaux, mais en plus fort

**Voici une démonstration du jeu final avec le build :**

**Démonstration :**

![Démonstration](https://github.com/DamienLegros/doodle-jump/blob/main/Demo.gif?raw=true)
