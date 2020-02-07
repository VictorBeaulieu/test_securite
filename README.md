# Projet

## Groupe projet

* Victor Beaulieu
* Aubin Gouhier
* Corentin Le Nel
* Alexandre Plociniczak

## Fonction
Ce logiciel permet de gérer les stocks d'un ensemble de magasin ainsi que les rayons et les produits de chacun.<br/>
Voici les fontionnalités princiaples :
* gestion des magasins (ajout/suppresion)
* gestion des rayons (ajout/suppresion)
* gestion des produits (ajout/suppresion)
* gestion des utilisateurs (ajout/suppresion)
* gestion du profil de l'utilisateur (changement de mot de passe)

## Exemples
Plusieurs captures d'écran sont disponinle dans le répertoire [image](https://github.com/VictorBeaulieu/test_securite/blob/master/image). <br/>
![login_form1](https://github.com/VictorBeaulieu/test_securite/blob/master/image/login_form1.png)<br/>
![menu_option](https://github.com/VictorBeaulieu/test_securite/blob/master/image/menu_option.png)

## Installation

Ce projet est réalisé avec Visual Studio Community 2019.<br/>
Pour ouvrir le projet, il faut ouvrir le fichier projet '[detaclon.sln](https://github.com/VictorBeaulieu/test_securite/blob/master/detaclon.sln)' situé à la racine du dépot .<br/><br/>
Si des difficultés à accéder à la database local du projet, assurez-vous d'avoir installé les packets SQL Server Data Tools pour Visual Studio : 
[SQL Server Data Tools](https://docs.microsoft.com/fr-fr/sql/ssdt/download-sql-server-data-tools-ssdt?view=sql-server-ver15&fbclid=IwAR3JL_AtK496_2khGUlI5h2o15sUTON6fnmoDVBX4HIeK2ULMitOZIg4nh0)

## Login
Pour ce connecter, utilisez l'un des comptes suivant (utilisez LoginID et LoginPWD) : <br/> ![all_logins](https://github.com/VictorBeaulieu/test_securite/blob/master/image/all_logins.png)

## Production

Pour la mise en production, il faut utiliser l'utillitaire de création d'installeur.<br/>
![make_installer_1](https://github.com/VictorBeaulieu/test_securite/blob/master/image/make_installer_1.png)<br/>
![make_installer_2](https://github.com/VictorBeaulieu/test_securite/blob/master/image/make_installer_2.png)

L'installateur sera fournit au client, le soft se connectera automatiquement à la database qui elle sera déployer soit sur un serveur distant, soit chez le client.
Le moyen de déployment du soft au client peut être :
* une clé usb
* un CD-ROM
* un lien FTP pour télécharger le soft