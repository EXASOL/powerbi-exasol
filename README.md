# Power BI - Exasol Connector
The Exasol Microsoft Power BI Connector enables you to connect from Power BI Desktop to Exasol in *Direct Query* mode (classical import mode is supported as well).

**The Exasol Microsoft Power BI Connector is a Certified Custom Connector now and is also shipped with Power BI desktop and the on premise data gateway. The powerbi-exasol repository will contain the latest release which might contain modifications not yet included in the stable version.**

## Prerequisites

* Install the [Exasol ODBC driver (EXASOL_ODBC_*.msi)](https://www.exasol.com/portal/display/DOWNLOAD/6.0) (if you are not sure if you shall install the 32 Bit or 64 Bit version install both versions)
* Install the current version of Power BI desktop

## Use the Custom Connector from this Repository instead of the official shipped connector in Power BI Desktop

:exclamation: The Power BI Release 2.66.5376.1681 64-bit (February 2019) contains all recent fixes of the EXASOL connector regarding unicode.

If you want to use the most current connector provided in this repository to be able to use the newest connector available, before the
next official release of Power BI, please us the following instructions:

* Download [Exasol.mez](https://github.com/EXASOL/powerbi-exasol/blob/master/Exasol/bin/Release/Exasol.mez) 
* Create A directory like  [Documents]\Power BI Desktop\Custom Connectors
* Copy Exasol.mez into the [Documents]\Power BI Desktop\Custom Connectors directory
* Open Power BI Desktop and  lower the security level for extensions in Power BI Desktop to enable loading unsigned/uncertified connectors.
* Go to File | Options and settings | Options
* Go the Security tab
* Under Data Extensions, select Allow any extension to load without warning or validation
* Restart Power BI Desktop
* Now Power BI uses the Custom Connector for Exasol instead of the official included connector

## Usage

1. Choose  Get Data -> Database -> Exasol

![alt text](https://github.com/EXASOL/powerbi-exasol/blob/master/screenshots/Get_Data_Exasol.PNG )

2. Enter the Exasol connection string and choose Direct Query

![alt text](https://github.com/EXASOL/powerbi-exasol/blob/master/screenshots/Exasol_Connection_String.PNG )

3. Enter credentials

![alt text](https://github.com/EXASOL/powerbi-exasol/blob/master/screenshots/Enter_Credentials.PNG )

4. Select tables

![alt text](https://github.com/EXASOL/powerbi-exasol/blob/master/screenshots/Navigator.PNG )

5. Review relational model, it's recommended to have foreign keys set in the database so Power BI can autodetect the relations

![alt text](https://github.com/EXASOL/powerbi-exasol/blob/master/screenshots/PowerBI_RelationalModel.PNG )

6. Build fast dashboards on billions of rows in Exasol

![alt text](https://github.com/EXASOL/powerbi-exasol/blob/master/screenshots/Example_Dashboard_Billion_Rows.PNG )


## How To use the Exasol Power BI Connector with the On-premises data gateway

The Exasol connector was tested successfully with the On-premises data gateway version 3000.8.452 (August 2019) and also supports Direct Query. 

:exclamation: As the Exasol Connector is now shipped with the On-premises data gateway it is not necessary to install the Exasol.mez from this repository in the Custom Connectos folder of the Gateway. Actually the data gateway only works with the shipped connector from Microsoft. If you upgrade from older version versions of the On-Premises data gateway please delete the Exasol.mez from the custom connectors folder and restart the gateway service.



