Imports DevExpress.XtraEditors
Imports System.IO
Imports MySql.Data.MySqlClient

Module UpdateEngine
    Dim engineupdated As Boolean = False
    Dim features As String = ""

    Public Sub SystemDatabaseUpdater()
        On Error Resume Next
        Dim updateVersion As String = "" : Dim updateDescription As String = ""
        
        updateVersion = "2019-06-10"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tbltransactionentries` ADD COLUMN `trncode` VARCHAR(45) NOT NULL DEFAULT '' AFTER `itemname`, ADD COLUMN `trnname` VARCHAR(100) NOT NULL DEFAULT '' AFTER `trncode`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblcollectionitem` (  `trncode` int(10) unsigned NOT NULL AUTO_INCREMENT,  `trnname` varchar(100) NOT NULL,  `glitemcode` varchar(45) NOT NULL,  PRIMARY KEY (`trncode`)) ENGINE=InnoDB AUTO_INCREMENT=103 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2019-06-11"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblclientaccess` ADD COLUMN `collectionreport` BOOLEAN NOT NULL DEFAULT 0 AFTER `communitytax`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblcollectionlist` ADD COLUMN `postingdate` DATE NOT NULL AFTER `yeartrn`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbltransactionentries` ADD COLUMN `postingdate` DATE NOT NULL AFTER `yeartrn`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblcommunitytax` CHANGE COLUMN `postingdate` `postingdate` DATE NOT NULL after yeartrn;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update `tbltransactionentries` set postingdate=date_format(datetrn,'%Y-%m-%d');" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update `tblcollectionlist` set postingdate=date_format(datetrn,'%Y-%m-%d');" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2019-06-12"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblclientaccess` ADD COLUMN `realpropertytax` BOOLEAN NOT NULL DEFAULT 0 AFTER `communitytax`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbltaxdeclaration` ADD COLUMN `cifid` VARCHAR(45) NOT NULL AFTER `propertyno`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbltaxdeclaration` ADD INDEX `cifid`(`cifid`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbltaxdeclaration` ADD COLUMN `improvement` DOUBLE NOT NULL DEFAULT 0 AFTER `assessedvalue`, ADD COLUMN `totalassessedvalue` DOUBLE NOT NULL DEFAULT 0 AFTER `improvement`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2019-06-13"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblclientaccess` ADD COLUMN `businessmgt` BOOLEAN NOT NULL DEFAULT 0 AFTER `accountableform`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2019-07-16"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tbltransactionentries` ADD COLUMN `cancelled` BOOLEAN NOT NULL DEFAULT 0, ADD COLUMN `cancelledby` VARCHAR(45) AFTER `cancelled`, ADD COLUMN `datecancelled` DATETIME AFTER `cancelledby`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2019-07-18"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE `tblbusiness` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `cifid` varchar(45) NOT NULL,  `companyname` varchar(100) NOT NULL,  `address` varchar(200) NOT NULL,  `dateregincorporation` date NOT NULL,  `placeincorporation` varchar(100) NOT NULL,  `kindoforganization` varchar(20) NOT NULL,  `businessnature` varchar(45) NOT NULL,  `contactperson` varchar(105) DEFAULT NULL,  `contactnumber` varchar(45) DEFAULT NULL,  `tin` varchar(45) NOT NULL,  `actived` tinyint(1) NOT NULL DEFAULT '0',  `trnby` varchar(45) NOT NULL,  `datetrn` datetime NOT NULL,  `deleted` tinyint(1) NOT NULL DEFAULT '0',  `deletedby` varchar(45) DEFAULT NULL,  `datedeleted` datetime DEFAULT NULL,  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblcommunitytaxcorp` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `fundcode` varchar(5) NOT NULL,  `yeartrn` varchar(4) NOT NULL,  `postingdate` date NOT NULL,  `jevno` varchar(100) NOT NULL,  `cifid` varchar(45) NOT NULL,  `companyid` varchar(100) NOT NULL,  `communitytaxno` varchar(45) NOT NULL,  `basiccomunitytax` double NOT NULL DEFAULT '0',  `additionalcomunitytax` double NOT NULL DEFAULT '0',  `inputrealproperty` double NOT NULL DEFAULT '0',  `totalrealproperty` double NOT NULL DEFAULT '0',  `inputgrossreceipts` double NOT NULL DEFAULT '0',  `totalgrossreceipts` double NOT NULL DEFAULT '0',  `subtotal` double NOT NULL DEFAULT '0',  `intrate` double NOT NULL DEFAULT '0',  `interest` double NOT NULL DEFAULT '0',  `amountpaid` double NOT NULL DEFAULT '0',  `paymentamount` double NOT NULL DEFAULT '0',  `paymentchange` double NOT NULL DEFAULT '0',  `processedby` varchar(100) NOT NULL,  `dateprocessed` datetime NOT NULL,  `cancelled` tinyint(1) NOT NULL DEFAULT '0',  `cancelledby` varchar(100) NOT NULL DEFAULT '',  `datecancelled` datetime DEFAULT NULL,  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbldefaultsettings` CHANGE COLUMN `defaultcedula` `defaultcedulaindividual` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbldefaultsettings` ADD COLUMN `defaultcedulacorporate` VARCHAR(45) NOT NULL AFTER `defaultcedulaindividual`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblclientaccess` CHANGE COLUMN `communitytax` `cedulaindividual` TINYINT(1) NOT NULL DEFAULT 0;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblclientaccess` MODIFY COLUMN `realpropertymgt` TINYINT(1) NOT NULL DEFAULT 0, MODIFY COLUMN `journalentryvoucher` TINYINT(1) NOT NULL DEFAULT 0, ADD COLUMN `cedulacorporate` TINYINT(1) NOT NULL DEFAULT 0 AFTER `cedulaindividual`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbltaxpayerprofile` CHANGE COLUMN `civistatus` `civilstatus` VARCHAR(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbltaxpayerprofile` ADD COLUMN `deleted` BOOLEAN NOT NULL DEFAULT 0 AFTER `entryby`, ADD COLUMN `deletedby` VARCHAR(45) NOT NULL DEFAULT '' AFTER `deleted`, ADD COLUMN `datedeleted` DATETIME AFTER `deletedby`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbltransactionentries` ADD COLUMN `companyid` VARCHAR(45) NOT NULL DEFAULT '' AFTER `cifid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbltaxpayerprofile` MODIFY COLUMN `civilstatus` VARCHAR(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2019-10-14"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblglitem` ADD COLUMN `expenditure` BOOLEAN NOT NULL DEFAULT 0 AFTER `cedula`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2019-10-16"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tbltransactionentries` ADD COLUMN `expglitemcode` VARCHAR(45) NOT NULL DEFAULT '' AFTER `credit`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `lgufiledir`.`tblattachmentlogs` ADD COLUMN `docname` VARCHAR(45) NOT NULL DEFAULT '' AFTER `trntype`, ADD COLUMN `filecode` VARCHAR(45) NOT NULL DEFAULT '' AFTER `docname`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `lgufiledir`.`tblattachmentlogs` ADD INDEX `refnumber`(`refnumber`),ADD INDEX `docname`(`docname`), ADD INDEX `filecode`(`filecode`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblclientaccess` ADD COLUMN `forapproval` TINYINT(1) NOT NULL DEFAULT 0 AFTER `journalentryvoucher`, ADD COLUMN `newrequisition` TINYINT(1) NOT NULL DEFAULT 0 AFTER `forapproval`, ADD COLUMN `requisitionlist` TINYINT(1) NOT NULL DEFAULT 0 AFTER `newrequisition`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblclientaccess` ADD COLUMN `newdisbursement` TINYINT(1) NOT NULL DEFAULT 0 AFTER `requisitionlist`, ADD COLUMN `disbursementlist` TINYINT NOT NULL DEFAULT 0 AFTER `newdisbursement`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblclientaccess` MODIFY COLUMN `disbursementlist` TINYINT(1) NOT NULL DEFAULT 0, ADD COLUMN `budgetreport` TINYINT(1) NOT NULL DEFAULT 0 AFTER `disbursementlist`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblcompoffice` ADD COLUMN `accounting` BOOLEAN NOT NULL DEFAULT 0 AFTER `deleted`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `budgetdefaultday` INTEGER UNSIGNED NOT NULL DEFAULT 9 AFTER `allowableattachsize`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblaccounts` ADD COLUMN `executiveofficer` BOOLEAN NOT NULL DEFAULT 0 AFTER `profileimg`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblaccounts` ADD COLUMN `financeofficer` BOOLEAN NOT NULL DEFAULT 0 AFTER `executiveofficer`, ADD COLUMN `sangguniansecretary` BOOLEAN NOT NULL DEFAULT 0 AFTER `financeofficer`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblcompoffice` ADD COLUMN `centercode` VARCHAR(45) NOT NULL AFTER `shortname`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblaccounts` ADD COLUMN `accountant` BOOLEAN NOT NULL DEFAULT 0 AFTER `executiveofficer`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2020-02-21"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblglitem` DROP COLUMN `fundcode`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2020-11-09"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tbldisbursementvoucher` DROP COLUMN `typeofpayment`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbldisbursementvoucher` ADD COLUMN `officeid` VARCHAR(45) NOT NULL DEFAULT '' AFTER `voucherdate`, ADD COLUMN `checkno` VARCHAR(45) NOT NULL DEFAULT '' AFTER `amount`, ADD COLUMN `checkbank` VARCHAR(100) NOT NULL DEFAULT '' AFTER `checkno`, ADD COLUMN `checkdate` DATE AFTER `checkbank`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "DROP TABLE `tbldisbursementvoucheritem`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblexpenditureitem` ADD COLUMN `isbank` BOOLEAN NOT NULL DEFAULT 0 AFTER `description`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbljournalentryitem` DROP COLUMN `tagcenter`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbljournalentryvoucher` ADD COLUMN `officeid` VARCHAR(45) NOT NULL DEFAULT '' AFTER `periodcode`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2020-11-11"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE `tblrequisitionfund` (  `id` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,  `pid` VARCHAR(45) NOT NULL DEFAULT '',  `officeid` VARCHAR(45) NOT NULL DEFAULT '',  `periodcode` VARCHAR(45) NOT NULL DEFAULT '',  `requestno` VARCHAR(45) NOT NULL DEFAULT '',  `itemcode` VARCHAR(45) NOT NULL DEFAULT '',  `amount` DOUBLE NOT NULL DEFAULT 0,  PRIMARY KEY (`id`))ENGINE = InnoDB;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblrequisition` DROP COLUMN `sourcefund`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblrequisitionitem` DROP COLUMN `sourcefund`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2020-12-21"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tbljournalentryvoucher` ADD COLUMN `obligationno` VARCHAR(45) NOT NULL DEFAULT '' AFTER `dvno`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblcompanysettings` ADD COLUMN `budgetname` VARCHAR(100) NOT NULL DEFAULT '' AFTER `treasurerposition`, ADD COLUMN `budgetposition` VARCHAR(100) NOT NULL DEFAULT '' AFTER `budgetname`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2021-01-02"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE `tblrequisitionfilter` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `requestcode` varchar(45) NOT NULL DEFAULT '',  `officeid` varchar(45) NOT NULL DEFAULT '',  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblfundfilter` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `fundcode` varchar(45) NOT NULL,  `officeid` varchar(45) NOT NULL DEFAULT '',  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblfund` ADD COLUMN `template` VARCHAR(10) NOT NULL DEFAULT '' AFTER `description`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2021-01-05"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblrequisitionfund` ADD COLUMN `prevbalance` DOUBLE NOT NULL DEFAULT 0 AFTER `itemcode`, ADD COLUMN `newbalance` DOUBLE NOT NULL DEFAULT 0 AFTER `amount`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2021-01-16"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tbldisbursementdetails` ADD COLUMN `trnreference` VARCHAR(45) NOT NULL DEFAULT '' AFTER `cancelled`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblcompoffice` ADD COLUMN `sb` BOOLEAN NOT NULL DEFAULT 0 AFTER `accounting`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblcompanysettings` ADD COLUMN `vicemayorname` VARCHAR(100) NOT NULL DEFAULT '' AFTER `mayorposition`, ADD COLUMN `vicemayorposition` VARCHAR(100) NOT NULL DEFAULT '' AFTER `vicemayorname`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblglcashitem` (  `id` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,  `itemcode` VARCHAR(45) NOT NULL,  PRIMARY KEY (`id`)) ENGINE = InnoDB;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbljournalentryitem` MODIFY COLUMN `classcode` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbljournalentryitem` ADD COLUMN `cashflowitem` VARCHAR(45) NOT NULL DEFAULT '' AFTER `classcode`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2021-01-28"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE  `tblbudgetquarter` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `fundperiod` varchar(8) NOT NULL,  `quartercode` varchar(2) NOT NULL DEFAULT '',  `quartername` varchar(45) NOT NULL,  `quarterbegin` varchar(2) NOT NULL DEFAULT '',  `quarterend` varchar(2) NOT NULL,  `closed` tinyint(1) NOT NULL DEFAULT '0',  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblrequisition` ADD COLUMN `headofficeapproval` BOOLEAN NOT NULL DEFAULT 0 AFTER `hold`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblrequisitiontype` ADD COLUMN `directapproved` BOOLEAN NOT NULL DEFAULT 0 AFTER `enablepo`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblbudgetcomposition` ADD COLUMN `quarter` VARCHAR(2) NOT NULL DEFAULT '' AFTER `itemname`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblbudgetcomposition` ADD COLUMN `totalbudget` DOUBLE NOT NULL DEFAULT 0 AFTER `amount`, ADD COLUMN `quarter1` DOUBLE NOT NULL DEFAULT 0 AFTER `totalbudget`, ADD COLUMN `quarter2` DOUBLE NOT NULL DEFAULT 0 AFTER `quarter1`, ADD COLUMN `quarter3` DOUBLE NOT NULL DEFAULT 0 AFTER `quarter2`, ADD COLUMN `quarter4` DOUBLE NOT NULL DEFAULT 0 AFTER `quarter3`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update `tblbudgetcomposition` Set totalbudget=amount;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update `tblbudgetcomposition` Set amount=0;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblrequisitionfund` ADD COLUMN `quarter` VARCHAR(2) NOT NULL DEFAULT '' AFTER `requestno`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblrequisitionfund` ADD COLUMN `cancelled` BOOLEAN NOT NULL DEFAULT 0 AFTER `newbalance`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblrequisitionfund` ADD COLUMN `classcode` VARCHAR(45) NOT NULL DEFAULT '' AFTER `quarter`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblcompoffice` ADD COLUMN `aro` BOOLEAN NOT NULL DEFAULT 0 AFTER `deleted`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblcompoffice` DROP COLUMN `accounting`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblapprovingprocess` ADD COLUMN `fundcode` VARCHAR(45) NOT NULL DEFAULT '' AFTER `trncode`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "delete from `tblapprovingprocess`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblapprovalhistory` ADD COLUMN `fundcode` VARCHAR(45) NOT NULL DEFAULT '' AFTER `trncode`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE  `tblfund` ADD COLUMN `aro` BOOLEAN NOT NULL DEFAULT 0 AFTER `template`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2021-01-30"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblcompoffice` DROP COLUMN `aro`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblfund` DROP COLUMN `aro`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblglaroexemption` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `itemcode` varchar(45) NOT NULL,  `itemname` varchar(1000) NOT NULL DEFAULT '',  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2021-01-31"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblproducts` DROP COLUMN `classcode`, DROP COLUMN `classificationname`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2021-02-08"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblrequisition` ADD COLUMN `checkapproved` BOOLEAN NOT NULL DEFAULT 0 AFTER `dateapproved`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblcheckapprovalfilter` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `permissioncode` varchar(45) NOT NULL DEFAULT '',  `officeid` varchar(45) NOT NULL DEFAULT '',  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=0 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblclientaccess` ADD COLUMN `checkapproval` TINYINT(1) NOT NULL DEFAULT 0 AFTER `forapproval`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2021-02-11"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblrequisition` ADD INDEX `currentapprover`(`currentapprover`), ADD INDEX `nextapprover`(`nextapprover`), ADD INDEX `cancelledby`(`cancelledby`), ADD INDEX `periodcode`(`periodcode`), ADD INDEX `fundcode`(`fundcode`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblrequisitionfund` ADD INDEX `pid`(`pid`), ADD INDEX `officeid`(`officeid`), ADD INDEX `periodcode`(`periodcode`), ADD INDEX `requestno`(`requestno`), ADD INDEX `itemcode`(`itemcode`), ADD INDEX `classcode`(`classcode`), ADD INDEX `quarter`(`quarter`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbldisbursementdetails` ADD INDEX `pid`(`pid`), ADD INDEX `requestno`(`requestno`), ADD INDEX `requesttype`(`requesttype`), ADD INDEX `officeid`(`officeid`), ADD INDEX `voucherno`(`voucherno`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbldisbursementvoucher` ADD INDEX `fundcode`(`fundcode`), ADD INDEX `officeid`(`officeid`), ADD INDEX `supplierid`(`supplierid`), ADD INDEX `clearedby`(`clearedby`), ADD INDEX `cancelledby`(`cancelledby`), ADD INDEX `trnby`(`trnby`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblrequisitionfiles` ADD INDEX `trnby`(`trnby`), ADD INDEX `requesttype`(`requesttype`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblrequisitionfilter` ADD INDEX `requestcode`(`requestcode`), ADD INDEX `officeid`(`officeid`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbljournalentryitem` ADD INDEX `jevno`(`jevno`), ADD INDEX `fundcode`(`fundcode`), ADD INDEX `periodcode`(`periodcode`), ADD INDEX `centercode`(`centercode`), ADD INDEX `classcode`(`classcode`), ADD INDEX `cashflowitem`(`cashflowitem`), ADD INDEX `itemcode`(`itemcode`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbljournalentryvoucher` ADD INDEX `jevno`(`jevno`), ADD INDEX `fundcode`(`fundcode`), ADD INDEX `periodcode`(`periodcode`), ADD INDEX `officeid`(`officeid`), ADD INDEX `trnby`(`trnby`), ADD INDEX `dvno`(`dvno`), ADD INDEX `clearedby`(`clearedby`), ADD INDEX `cancelledby`(`cancelledby`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2021-02-15"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblrequisition` ADD COLUMN `payee` VARCHAR(45) NOT NULL DEFAULT '' AFTER `requestedby`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblrequisitiontype` ADD COLUMN `enablevoucher` TINYINT(1) NOT NULL DEFAULT 1 AFTER `description`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbljournalentryvoucher` ADD COLUMN `pid` VARCHAR(45) NOT NULL DEFAULT '' AFTER `aeno`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblclientaccess` ADD COLUMN `newdirectjournal` TINYINT(1) NOT NULL DEFAULT 0 AFTER `realpropertymgt`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblrequisition` ADD COLUMN `jev` BOOLEAN NOT NULL DEFAULT 0 AFTER `paid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update `tblrequisition` set jev=1 where pid in (select a.pid from tbldisbursementdetails as a inner join tbljournalentryvoucher as b on a.voucherno=b.dvno);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbldisbursementdetails` ADD COLUMN `payee` VARCHAR(45) NOT NULL DEFAULT '' AFTER `requesttype`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2021-02-18"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblrequisition` ADD COLUMN `voucher` BOOLEAN NOT NULL DEFAULT 0 AFTER `checkapproved`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update tblrequisition set voucher=paid;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update tblrequisition set paid=0;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update tblrequisition set paid=1 where pid in (select pid from tbldisbursementdetails as a inner join tbldisbursementvoucher as b on a.voucherno=b.voucherno where b.checkno<>'');" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblrequisition` ADD COLUMN `cleared` BOOLEAN NOT NULL DEFAULT 0 AFTER `jev`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2021-02-22"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tbljournalentryvoucher` ADD COLUMN `pid` VARCHAR(45) NOT NULL DEFAULT '' AFTER `aeno`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update `tblrequisition` set voucher=1 where pid in (select pid from tbldisbursementdetails);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update tblrequisition set paid=0;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update tblrequisition set paid=1 where pid in (select pid from tbldisbursementdetails as a inner join tbldisbursementvoucher as b on a.voucherno=b.voucherno where b.checkno<>'');" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2021-03-12"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblbudgetcomposition` ADD COLUMN `January` DOUBLE NOT NULL DEFAULT 0 AFTER `totalbudget`, ADD COLUMN `february` DOUBLE NOT NULL DEFAULT 0 AFTER `January`, ADD COLUMN `march` DOUBLE NOT NULL DEFAULT 0 AFTER `february`, ADD COLUMN `april` DOUBLE NOT NULL DEFAULT 0 AFTER `march`, ADD COLUMN `may` DOUBLE NOT NULL DEFAULT 0 AFTER `april`, ADD COLUMN `june` DOUBLE NOT NULL DEFAULT 0 AFTER `may`, ADD COLUMN `july` DOUBLE NOT NULL DEFAULT 0 AFTER `june`, ADD COLUMN `august` DOUBLE NOT NULL DEFAULT 0 AFTER `july`, ADD COLUMN `september` DOUBLE NOT NULL DEFAULT 0 AFTER `august`, ADD COLUMN `october` DOUBLE NOT NULL DEFAULT 0 AFTER `september`, ADD COLUMN `november` DOUBLE NOT NULL DEFAULT 0 AFTER `october`, ADD COLUMN `december` DOUBLE NOT NULL DEFAULT 0 AFTER `november`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblbudgetcomposition` DROP COLUMN `quarter1`, DROP COLUMN `quarter2`, DROP COLUMN `quarter3`, DROP COLUMN `quarter4`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "delete from `tblrequisitionfund` where quarter='';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblbudgetquarter` CHANGE COLUMN `quartercode` `monthcode` VARCHAR(2) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL, CHANGE COLUMN `quartername` `monthname` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL, CHANGE COLUMN `quarterbegin` `monthseries` VARCHAR(2) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL, DROP COLUMN `quarterend`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblbudgetquarter` RENAME TO `tblbudgetmonthly`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblbudgetmonthly` DROP COLUMN `monthseries`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblbudgetcomposition` CHANGE COLUMN `quarter` `monthcode` VARCHAR(2) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblrequisitionfund` CHANGE COLUMN `quarter` `monthcode` VARCHAR(2) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL, DROP INDEX `quarter`, ADD INDEX `quarter` USING BTREE(`monthcode`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update `tblrequisitionfund` set monthcode=SUBSTRING_INDEX(SUBSTRING_INDEX(requestno, '-', -2), '-', 1);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2021-03-16"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tbljournalentryvoucher` ADD COLUMN `dvid` VARCHAR(45) NOT NULL DEFAULT '' AFTER `remarks`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbldisbursementvoucher` CHANGE COLUMN `id` `voucherid` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT, DROP PRIMARY KEY, ADD PRIMARY KEY  USING BTREE(`voucherid`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbldisbursementvoucher` ADD COLUMN `pid` VARCHAR(45) NOT NULL DEFAULT '' AFTER `voucherno`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbldisbursementdetails` ADD COLUMN `voucherid` VARCHAR(45) NOT NULL DEFAULT '' AFTER `id`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbldisbursementdetails` ADD INDEX `voucherid`(`voucherid`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update `tbldisbursementdetails` set voucherid=(select voucherid from tbldisbursementvoucher as a where a.voucherno=tbldisbursementdetails.voucherno);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update `tbljournalentryvoucher` set dvid=ifnull((select voucherid from tbldisbursementvoucher as a where a.voucherno=tbljournalentryvoucher.dvno),'');" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update `tbldisbursementvoucher` set pid=ifnull((select pid from tbldisbursementdetails as a where a.voucherid=tbldisbursementvoucher.voucherid),'');" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update tbldisbursementvoucher set seriesno=concat('0',seriesno);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update tbldisbursementvoucher set voucherno=concat(SUBSTRING_INDEX(voucherno, '-', 3),'-0',SUBSTRING_INDEX(voucherno, '-', -1));" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update tbldisbursementdetails set voucherno=concat(SUBSTRING_INDEX(voucherno, '-', 3),'-0',SUBSTRING_INDEX(voucherno, '-', -1));" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))

            Dim fundcode() As String = {"100", "200", "300"}

            For Each fund In fundcode
                com.CommandText = "DROP TABLE IF EXISTS tmpvoucher" & fund & ";" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                com.CommandText = "CREATE TEMPORARY TABLE `tmpvoucher" & fund & "` (  `id` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,  `voucherid` VARCHAR(45) NOT NULL DEFAULT '',  PRIMARY KEY (`id`))ENGINE = InnoDB;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                com.CommandText = "insert into tmpvoucher" & fund & " (voucherid) SELECT voucherid FROM `tbldisbursementvoucher` where fundcode='" & fund & "';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                com.CommandText = "update tbldisbursementvoucher set seriesno=(select id from tmpvoucher" & fund & " as a where a.voucherid=tbldisbursementvoucher.voucherid) where fundcode='" & fund & "';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                com.CommandText = "update tbldisbursementvoucher set seriesno=if(LENGTH(seriesno)=1,concat('000',seriesno),if(LENGTH(seriesno)=2,concat('00',seriesno),concat('0',seriesno))) where fundcode='" & fund & "';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                com.CommandText = "update tbldisbursementvoucher set voucherno=concat(SUBSTRING_INDEX(voucherno, '-', 3),'-',seriesno) where fundcode='" & fund & "';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                com.CommandText = "update tbldisbursementdetails set voucherno=ifnull((select voucherno from tbldisbursementvoucher as a where a.voucherid=tbldisbursementdetails.voucherid),'');" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                com.CommandText = "update tbljournalentryvoucher set dvno=ifnull((select voucherno from tbldisbursementvoucher as a where a.voucherid=tbljournalentryvoucher.dvid),'');" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                com.CommandText = "DROP TABLE IF EXISTS tmpvoucher" & fund & ";" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            Next

            engineupdated = True
        End If

        updateVersion = "2021-03-17"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblrequisitionseries` RENAME TO `tbltransactionseries`, ADD COLUMN `id` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT first, ADD COLUMN `category` VARCHAR(45) NOT NULL DEFAULT '' AFTER `id`, DROP PRIMARY KEY, ADD PRIMARY KEY (`id`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update `tbltransactionseries` set category='requisition';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbldisbursementvoucher` MODIFY COLUMN `voucherid` VARCHAR(45) NOT NULL;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbldisbursementdetails` DROP COLUMN `trnreference`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbldisbursementvoucher` ADD COLUMN `checkissued` BOOLEAN NOT NULL DEFAULT 0 AFTER `amount`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE tbldisbursementvoucher set checkissued=1 where checkno<>'';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE `tblrequisition` set payee=ifnull((select supplierid from tbldisbursementvoucher as a where a.pid=tblrequisition.pid limit 1),'') where payee='';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2021-03-18"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "update tbldisbursementvoucher set clearedby='' where clearedby is null;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update tbldisbursementvoucher set cancelledby='' where cancelledby is null;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbldisbursementvoucher` MODIFY COLUMN `voucherid` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '', MODIFY COLUMN `voucherno` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '', MODIFY COLUMN `fundcode` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '', MODIFY COLUMN `periodcode` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '', MODIFY COLUMN `yearcode` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '', MODIFY COLUMN `seriesno` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '', MODIFY COLUMN `yeartrn` VARCHAR(4) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '', MODIFY COLUMN `supplierid` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '', MODIFY COLUMN `trnby` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '', MODIFY COLUMN `clearedby` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '', MODIFY COLUMN `cancelledby` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbljournalentryvoucher` DROP COLUMN `dvno`, DROP INDEX `dvno`, ADD INDEX `dvid`(`dvid`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2021-03-19"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tbldocumenttype` ADD COLUMN `required` BOOLEAN NOT NULL DEFAULT 1 AFTER `description`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2021-03-20"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblbankaccounts` ADD COLUMN `fundcode` VARCHAR(45) NOT NULL DEFAULT '' AFTER `id`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If


        updateVersion = "2021-03-25"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE  `lgufinancial`.`tblbudgethistory` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `periodcode` varchar(45) NOT NULL DEFAULT '',  `fundcode` varchar(45) NOT NULL DEFAULT '',  `yearcode` varchar(45) NOT NULL DEFAULT '',  `officeid` varchar(45) NOT NULL DEFAULT '',  `classcode` varchar(45) NOT NULL DEFAULT '',  `itemcode` varchar(45) NOT NULL DEFAULT '',  `itemname` varchar(500) NOT NULL,  `monthcode` varchar(2) NOT NULL DEFAULT '',  `totalbudget` double NOT NULL DEFAULT '0',  `amount` double NOT NULL DEFAULT '0',  `expended` double NOT NULL DEFAULT '0',  `balance` double NOT NULL DEFAULT '0',  PRIMARY KEY (`id`),  KEY `periodcode` (`periodcode`),  KEY `officeid` (`officeid`),  KEY `itemcode` (`itemcode`),  KEY `fundcode` (`fundcode`),  KEY `monthcode` (`monthcode`)) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2021-04-05"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "update tbljournalentryvoucher set pid=ifnull((select pid from tbldisbursementvoucher where voucherid=tbljournalentryvoucher.dvid),'') where pid='';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2021-04-14"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "update `tblrequisitionfund` set monthcode=SUBSTRING_INDEX(SUBSTRING_INDEX(requestno, '-', -2), '-', 1);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2021-05-11"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tbljournalentryitem` ADD COLUMN `fundreference` VARCHAR(45) NOT NULL DEFAULT '' AFTER `cancelled`; " : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbljournalentryitem` ADD INDEX `fundreference`(`fundreference`); " : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2021-07-08"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblclientaccess` ADD COLUMN `humanresource` TINYINT(1) NOT NULL DEFAULT 0 AFTER `budgetreport`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2021-06-11"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblrequisitiontype` ADD COLUMN `requiredfund` BOOLEAN NOT NULL DEFAULT 1 AFTER `directapproved`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2021-07-23"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblcompanysettings` ADD COLUMN `hrmdname` VARCHAR(100) NOT NULL DEFAULT '' AFTER `budgetposition`, ADD COLUMN `hrmdposition` VARCHAR(100) NOT NULL DEFAULT '' AFTER `hrmdname`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblemployees` (  `id` varchar(20) NOT NULL,  `employeeid` varchar(20) NOT NULL,  `title` varchar(45) NOT NULL DEFAULT '',  `lastname` varchar(25) NOT NULL DEFAULT '',  `firstname` varchar(25) NOT NULL DEFAULT '',  `middlename` varchar(25) DEFAULT '',  `fullname` varchar(50) DEFAULT '',  `extname` varchar(6) DEFAULT '',  `nickname` varchar(40) DEFAULT '',  `birthdate` date DEFAULT NULL,  `birthplace` varchar(450) DEFAULT '',  `gender` varchar(6) NOT NULL DEFAULT '',  `spousename` varchar(100) NOT NULL DEFAULT '',  `height` varchar(10) NOT NULL DEFAULT '',  `weight` varchar(10) NOT NULL DEFAULT '',  `nationality` varchar(45) DEFAULT '',  `religion` varchar(45) DEFAULT '',  `civilstatus` varchar(45) DEFAULT '',  `per_add_purok` varchar(100) DEFAULT '',  `per_add_brgy` varchar(65) DEFAULT '',  `per_add_city` varchar(45) DEFAULT '',  `per_add_prov` varchar(45) DEFAULT '',  `cur_add_purok` varchar(100) DEFAULT '',  `cur_add_brgy` varchar(65) DEFAULT '',  `cur_add_city` varchar(45) DEFAULT '',  `cur_add_prov` varchar(45) DEFAULT '',  `contactnumber` varchar(45) DEFAULT '',  `homenumber` varchar(45) DEFAULT '',  `emailaddress` varchar(45) DEFAULT '',  `inc_cont_person` varchar(65) DEFAULT '',  `inc_cont_number` varchar(45) DEFAULT '',  `inc_cont_address` varchar(75) DEFAULT '',  `officeid` varchar(15) DEFAULT '',  `designation` varchar(100) DEFAULT '',  `employeetype` varchar(15) DEFAULT '',  `positionlevel` varchar(15) DEFAULT '',  `baseratepay` varchar(45) DEFAULT '',  `basicrate` varchar(15) DEFAULT '',  `contractperiod` tinyint(1) DEFAULT '0',  `contractstartdate` date DEFAULT NULL,  `contractenddate` date DEFAULT NULL,  `datehired` date DEFAULT NULL,  `dateregular` date DEFAULT NULL,  `resigned` tinyint(1) NOT NULL DEFAULT '0',  `dateresigned` date DEFAULT NULL,  `retired` tinyint(1) NOT NULL DEFAULT '0',  `dateretired` date DEFAULT NULL,  `dateregistered` datetime NOT NULL,  `registeredby` varchar(10) NOT NULL DEFAULT '',  `dateupdated` datetime DEFAULT NULL,  `updatedby` varchar(10) DEFAULT '',  PRIMARY KEY (`id`) USING BTREE,  KEY `employeeid` (`employeeid`),  KEY `lastname` (`lastname`),  KEY `firstname` (`firstname`),  KEY `fullname` (`fullname`),  KEY `officeid` (`officeid`),  KEY `nationality` (`nationality`),  KEY `religion` (`religion`),  KEY `civilstatus` (`civilstatus`),  KEY `designation` (`designation`),  KEY `employeetype` (`employeetype`),  KEY `positionlevel` (`positionlevel`),  KEY `baseratepay` (`baseratepay`),  KEY `basicrate` (`basicrate`)) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblemployeepic` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `employeeid` varchar(45) NOT NULL,  `img` longblob,  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=0 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblemployeeservice` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `employeeid` varchar(10) NOT NULL,  `datefrom` date DEFAULT NULL,  `dateto` date DEFAULT NULL,  `desigid` varchar(10) NOT NULL,  `statusid` varchar(10) NOT NULL,  `salaryrate` double NOT NULL DEFAULT '0',  `baserate` varchar(10) NOT NULL,  `companyid` varchar(10) NOT NULL,  `branchid` varchar(10) NOT NULL,  `lv_abs_wpay` varchar(45) NOT NULL,  `sep_date` date DEFAULT NULL,  `sep_causeid` varchar(10) NOT NULL,  PRIMARY KEY (`id`)) ENGINE=MyISAM AUTO_INCREMENT=0 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblemployeeeducation` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `employeeid` varchar(45) NOT NULL DEFAULT '',  `educationtype` varchar(45) NOT NULL DEFAULT '',  `schoolid` varchar(10) NOT NULL DEFAULT '',  `courseid` varchar(10) NOT NULL DEFAULT '',  `datefrom` date DEFAULT NULL,  `dateto` date DEFAULT NULL,  `schoollevel` int(10) unsigned NOT NULL,  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=0 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblemployeecertification` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `employeeid` varchar(45) NOT NULL,  `certissuedfrom` varchar(10) NOT NULL,  `certid` varchar(10) NOT NULL,  `certno` varchar(45) DEFAULT NULL,  `certdate` date DEFAULT NULL,  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=0 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblemployeecard` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `employeeid` varchar(45) NOT NULL DEFAULT '',  `cardtype` varchar(45) NOT NULL DEFAULT '',  `cardnumber` varchar(100) NOT NULL,  `withexpiry` tinyint(1) DEFAULT '0',  `dateexpired` date DEFAULT NULL,  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=0 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2021-08-05"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tbldisbursementvoucher` ADD COLUMN `checkamount` DOUBLE NOT NULL DEFAULT 0 AFTER `checkdate`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update tbldisbursementvoucher set checkamount=(select ifnull(sum(credit),0) as total from tbljournalentryvoucher as a inner join tbljournalentryitem as b on a.jevno=b.jevno where a.dvid=tbldisbursementvoucher.voucherid and itemcode in (select itemcode from tblglcashitem));" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2021-08-07"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblcompoffice` DROP COLUMN `officerid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2021-08-08"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE `tblcompofficerlog` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `officeid` varchar(45) NOT NULL,  `officerid` varchar(45) NOT NULL,  `position` varchar(100) NOT NULL,  `datefrom` date NOT NULL,  `dateto` date DEFAULT NULL,  `current` tinyint(1) NOT NULL DEFAULT '0',  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2021-08-27"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE `tblglreverseitem` (  `id` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,  `itemcode` VARCHAR(45) NOT NULL DEFAULT '',  `itemname` VARCHAR(1000) NOT NULL DEFAULT '',  `debit` BOOLEAN NOT NULL DEFAULT 0,  `credit` BOOLEAN NOT NULL DEFAULT 0,  PRIMARY KEY (`id`))ENGINE = InnoDB;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblformreportlogs` ADD INDEX `invrefcode`(`invrefcode`), ADD INDEX `formcode`(`formcode`), ADD INDEX `accountable`(`accountable`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblforminventory` ADD INDEX `officeid`(`officeid`), ADD INDEX `formcode`(`formcode`), ADD INDEX `entryby`(`entryby`), ADD INDEX `accountable`(`accountable`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2021-10-29"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblcollectionitem` ADD COLUMN `amount` DOUBLE NOT NULL DEFAULT 0 AFTER `glitemcode`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblcollectionitem` ADD COLUMN `deleted` BOOLEAN NOT NULL DEFAULT 0 AFTER `amount`, ADD COLUMN `datedeleted` DATETIME AFTER `deleted`, ADD COLUMN `deletedby` VARCHAR(10) NOT NULL DEFAULT '' AFTER `datedeleted`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblbudgettransferlogs` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `trncode` varchar(105) NOT NULL DEFAULT '',  `periodcode` varchar(45) NOT NULL DEFAULT '',  `fundcode` varchar(45) NOT NULL DEFAULT '',  `yearcode` varchar(45) NOT NULL DEFAULT '',  `monthcode` varchar(2) NOT NULL DEFAULT '',  `from_officeid` varchar(45) NOT NULL DEFAULT '',  `from_classcode` varchar(45) NOT NULL DEFAULT '',  `from_itemcode` varchar(45) NOT NULL DEFAULT '',  `from_itemname` varchar(500) NOT NULL,  `to_officeid` varchar(45) NOT NULL DEFAULT '',  `to_classcode` varchar(45) NOT NULL DEFAULT '',  `to_itemcode` varchar(45) NOT NULL DEFAULT '',  `to_itemname` varchar(500) NOT NULL,  `amounttransfer` double NOT NULL DEFAULT '0',  `datetransfer` datetime NOT NULL,  `transferby` varchar(10) NOT NULL DEFAULT '',  PRIMARY KEY (`id`),  KEY `periodcode` (`periodcode`),  KEY `from_officeid` (`from_officeid`),  KEY `from_itemcode` (`from_itemcode`),  KEY `to_officeid` (`to_officeid`),  KEY `to_itemcode` (`to_itemcode`),  KEY `transferby` (`transferby`)) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If


        If engineupdated = True Then
            Dim dversion As Date = updateVersion
            XtraMessageBox.Show("Your database engine was updated to Build Version " & dversion.ToString & Environment.NewLine & "Please view update list at ""Main System Menu"" > About > What's New!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            engineupdated = False
        End If
    End Sub

    Public Function DatabaseUpdateLogs(ByVal nVersions As String, ByVal strQuery As String)
        com.CommandText = "insert into tbldatabaseupdatelogs set databaseversion='" & nVersions & "',dateupdate=current_timestamp,appliedquery='" & strQuery & "'" : com.ExecuteNonQuery()
        Return 0
    End Function
End Module
