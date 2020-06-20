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
