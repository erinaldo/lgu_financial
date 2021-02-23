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
