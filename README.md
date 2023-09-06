# Introduction du projet 
Le projet consiste à créer une base de données Data Ware House pour des usages dans des projets d’analyses des données avec Sql Server Analysis Services, Power Plaform et bien d’autres projets et ce là pour le compte d’une entreprise de commerce international 

## Les données sujet d’analyse

Dans le cahier de charges, il est indiqué que les données principalement analysées seront 
* Le prix unitaire
* Le coût standard/total
* La quantité 

L’analyse des remises et hausses des prix sont également pris en considération 
Le total des ventes sera également inclus dans l’analyse
Concernant les frais connexes à étudier, il existe deux mesures à savoir les taxes et les frètes  
Après des points fait avec le client on arrive à définir les données à analyser dont voici une liste

 

## Les perspectives d’analyse
Les données seront analysées selon plusieurs perspectives 
* Les consommateurs
* Les produits
* Les dates
* Les promotions
* Les monnaies

Egalement après des réunions et des points avec le staff technique de la société on arrive à identifier les perspectives d’analyse techniquement appelées dimensions 
* La dimension consommateur
* La dimension produit
* La dimension monnaie
* La dimension promotion
* La dimension date
* 
Il est à noter qu’il faut prendre en considération deux régimes 
Le régime administratif
Le régime fiscal

Les analyses sont menées selon les périodes suivantes
* Le quotidien
* L’hebdomadaire
* Le trimestriel
* Le semestriel
* L’annuel
 
 

Il est à noter qu’il y a trois sortes de dates importantes à prendre en considération selon les besoins du client à savoir 
* La date de l’émission d’ordre
* La date d’expédition
* La date d’arrivage



Pour bien comprendre le projet, il faut créer deux base de données Data Ware House
* BusinessDB
* BusinessDB2 

La première base BusinessDB représente la base en état final tel qu’on doit la créer tandis que la deuxième base BusinessDB2 elle sera créé, elle sera vide au début et puis il faut l’alimenter avec les données à l’aide du système d’intégration de données SSIS qui va être développé au cours de ce projet 
La création des bases 

Pour commencer il faut chercher le dossier Data/ Dataware house scripts dans le fichier de ressources dé zippé Sources.rar 
 
Il faut lancer les scripts dans le Sql Server Management Studio dans l’ordre montré par l’image pour créer et remplir la première base. Pour ouvrir Sql Server Management Studio, il suffit de taper SSMS dans le champ recherche de Windows 11 
 	 

Une fois SSMS est lancé, il faut ensuite cliquer droit souris sur la base système master et choisir nouvelle requête ou New Query en anglais 
 
Il faut essayer ensuite d’exécuter les scripts dans le dossier Data/ Dataware house scripts dans l’ordre du haut vers le bas

* BusinessDB Schema script.txt
* DimCurrency data.txt
* DimCustomer data.txt
* DimProduct data.txt
* Dim promotion data.txt
* DimDate data.txt
* FactSales data.txt

Il faut ensuite chercher la base de données Business DB dans la liste des bases sinon il faut cliquer le bouton de rafraichissement pour forcer son apparence 
 
Cliquer ensuite droit souris sur la base de données Business DB et lancer une nouvelle requête
 
Lancer le script suivant pour permettre de créer les schémas 
exec sp_changedbowner @loginame='sa'

**Note :** il faut changer le compte **'sa'** par le nom de l’utilisateur actuel qui ouvre la session SQL Sevrer au cas du besoin. Il faut rappeler que  **'sa'** est le nom du compte utilisateur crée en cours de l’installation de SQL Server en mode de sécurité mixte
Cliquer en suite droit souris le dossier Database Diagrams pour créer un nouveau Diagrame
 
Sélectionner toutes les tables dans liste et cliquer Ajouter ou en anglais Add
 

En fin, essayer de parcourir les données dans la base nouvellement crée
Ensuite, il faut créer la deuxième base BusinessDB2 qui est identique à BusinessDB à la différence que cette deuxième base sera vide, elle servira pour le test du projet d’intégration des données qui sera développé dans les étapes suivantes
 Le déploiement du projet 

Déployer les packages un après l’autre et exécuter le package intitulé MainPackage, il faut avoir un résultat similaire à celui indiqué au-dessous
 


