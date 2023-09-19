 DECLARE @MONTH INT = '05';
		DECLARE @YEAR INT = '2016';
		DECLARE @DefAgency char(2) = '01';

DECLARE	@TBAddStartDate VARCHAR(10) = NULL;
		DECLARE @TBAddEndDate date = NULL;
		--DROP TABLE #tblDates

		SET @TBAddStartDate = CONVERT(VARCHAR(4),@YEAR)+'-'+CONVERT(VARCHAR(02),@MONTH)+'-'+'01';
		SET @TBAddEndDate = (SELECT DATEADD(DD,-(DAY(@TBAddStartDate)), DATEADD(MM, 1, @TBAddStartDate)));
		--SELECT @TBAddStartDate,@TBAddEndDate

		--** ALL DAYS IN MONTH **--
		;WITH N(N)AS 
		(SELECT 1 FROM(VALUES(1),(1),(1),(1),(1),(1))M(N)),
		tally(N)AS(SELECT ROW_NUMBER()OVER(ORDER BY N.N)FROM N,N a)
		SELECT N day,datefromparts(@YEAR,@MONTH,N) Mdate into #tblDates FROM tally
		WHERE N <= day(EOMONTH(datefromparts(@YEAR,@MONTH,1)))

		DECLARE @tblData table(CurrDay varchar(15), Mdate date, WRKDATES varchar(10),TBLTYPE varchar(300), Program varchar(150),ProgramCode varchar(10),TotalCount bigint, ORDBY INT)
		--*****************************************************--
		--INSERT INTO @tblData SELECT @TBAddStartDate AS WRKDATES,'         Intakes' AS TBLTYPE,NULL AS Program, NULL AS ProgramCode, NULL AS TotalCount, 1 as ORDBY
		--INSERT INTO @tblData SELECT @TBAddStartDate AS WRKDATES,'        Income Verified' AS TBLTYPE,NULL AS Program, NULL AS ProgramCode,NULL AS TotalCount, 2 as ORDBY
		--INSERT INTO @tblData SELECT @TBAddStartDate AS WRKDATES,'       Referrals to Programs' AS TBLTYPE,NULL AS Program, NULL AS ProgramCode,NULL AS TotalCount, 3 as ORDBY
		--INSERT INTO @tblData SELECT @TBAddStartDate AS WRKDATES,'      Referrals to Partners' AS TBLTYPE,NULL AS Program, NULL AS ProgramCode,NULL AS TotalCount, 4 as ORDBY
		--INSERT INTO @tblData SELECT @TBAddStartDate AS WRKDATES,'     Contacts' AS TBLTYPE,NULL AS Program, NULL AS ProgramCode,NULL AS TotalCount, 5 as ORDBY
		--INSERT INTO @tblData SELECT @TBAddStartDate AS WRKDATES,'    Service Plans' AS TBLTYPE,NULL AS Program, NULL AS ProgramCode,NULL AS TotalCount, 6 as ORDBY
		--INSERT INTO @tblData SELECT @TBAddStartDate AS WRKDATES,'   Services' AS TBLTYPE,NULL AS Program, NULL AS ProgramCode,NULL AS TotalCount, 7 as ORDBY
		--INSERT INTO @tblData SELECT @TBAddStartDate AS WRKDATES,'  Outcomes' AS TBLTYPE,NULL AS Program, NULL AS ProgramCode,NULL AS TotalCount, 8 as ORDBY
		--INSERT INTO @tblData SELECT @TBAddStartDate AS WRKDATES,' Assessments' AS TBLTYPE,NULL AS Program, NULL AS ProgramCode,NULL AS TotalCount, 9 as ORDBY
		--*****************************************************--
		--** CLIENT INTAKE COUNTS ***--
		;WITH TEMPINTAKE AS(
		SELECT MST_INTAKE_DATE AS WRKDATES,'         Intakes' AS TBLTYPE,
		dbo.Fun_GetHierarchy_Desc(3,MST_AGENCY,MST_DEPT,MST_PROGRAM) As Program,(MST_AGENCY+MST_DEPT+MST_PROGRAM) as ProgramCode,
		Count(*) AS TotalCount, 1 as ORDBY FROM CASEMST WHERE 
		((Cast(MST_INTAKE_DATE as Date) Between @TBAddStartDate AND @TBAddEndDate) OR (@TBAddStartDate IS NULL) OR (@TBAddEndDate IS NULL)) 
		AND MST_AGENCY=@DefAgency GROUP BY MST_INTAKE_DATE,MST_AGENCY,MST_DEPT,MST_PROGRAM )--ORDER BY MST_INTAKE_DATE
		
		INSERT INTO @tblData SELECT ('Day - '+ CONVERT(varchar(2),#tblDates.day)) AS CurrDay, Mdate,WRKDATES,ISNULL(TBLTYPE,'         Intakes') AS TBLTYPE,
		Program, ProgramCode,TotalCount,1 as ORDBY FROM #tblDates LEFT JOIN TEMPINTAKE ON Mdate=WRKDATES order by Mdate


		--** INCOME VERIFIED COUNTS ***--
		;WITH TEMPINCVER AS(SELECT  VER_VERIFY_DATE AS WRKDATES,'        Income Verified' AS TBLTYPE,
		dbo.Fun_GetHierarchy_Desc(3,VER_AGENCY,VER_DEPT,VER_PROGRAM) As Program,(VER_AGENCY+VER_DEPT+VER_PROGRAM) as ProgramCode,
		Count(*) AS TotalCount, 2 as ORDBY FROM CASEVER WHERE 
		((Cast(VER_VERIFY_DATE as Date) Between @TBAddStartDate AND @TBAddEndDate) OR (@TBAddStartDate IS NULL))  
		AND VER_AGENCY=@DefAgency GROUP BY VER_VERIFY_DATE,VER_AGENCY,VER_DEPT,VER_PROGRAM) --ORDER BY VER_VERIFY_DATE
		
		INSERT INTO @tblData SELECT ('Day - '+ CONVERT(varchar(2),#tblDates.day)) AS CurrDay, Mdate,WRKDATES,ISNULL(TBLTYPE,'        Income Verified') AS TBLTYPE,
		Program, ProgramCode,TotalCount,2 as ORDBY FROM #tblDates LEFT JOIN TEMPINCVER ON Mdate=WRKDATES order by Mdate

		--** PROGRAM REFERRALS COUNTS ***--
		;WITH TEMPPRGREFF AS(SELECT CASESUM_REFERDATE AS WRKDATES,'       Referrals to Programs' AS TBLTYPE,
		dbo.Fun_GetHierarchy_Desc(3,CASESUM_AGENCY,CASESUM_DEPT,CASESUM_PROGRAM) As Program,(CASESUM_AGENCY+CASESUM_DEPT+CASESUM_PROGRAM) as ProgramCode,
		Count(*) AS TotalCount, 3 as ORDBY FROM CASESUM WHERE 
		((Cast(CASESUM_REFERDATE as Date) Between @TBAddStartDate AND @TBAddEndDate) OR (@TBAddStartDate IS NULL))  
		AND CASESUM_AGENCY=@DefAgency GROUP BY CASESUM_REFERDATE,CASESUM_AGENCY,CASESUM_DEPT,CASESUM_PROGRAM )

		INSERT INTO @tblData SELECT ('Day - '+ CONVERT(varchar(2),#tblDates.day)) AS CurrDay, Mdate,WRKDATES,ISNULL(TBLTYPE,'       Referrals to Programs') AS TBLTYPE,
		Program, ProgramCode, TotalCount,3 as ORDBY FROM #tblDates LEFT JOIN TEMPPRGREFF ON Mdate=WRKDATES order by Mdate

			-- ** REFERRALS TO PARTNERS **--
		;WITH TEMPREFPART AS(SELECT ACTREFS_DATE AS WRKDATES,'      Referrals to Partners' AS TBLTYPE,
		dbo.Fun_GetHierarchy_Desc(3,ACTREFS_AGENCY,ACTREFS_DEPT,ACTREFS_PROGRAM) As Program,(ACTREFS_AGENCY+ACTREFS_DEPT+ACTREFS_PROGRAM) as ProgramCode,
		Count(*) AS TotalCount, 4 as ORDBY FROM ACTREFS WHERE 
		((Cast(ACTREFS_DATE as Date) Between @TBAddStartDate AND @TBAddEndDate) OR (@TBAddStartDate IS NULL))  
		AND ACTREFS_AGENCY=@DefAgency GROUP BY ACTREFS_DATE,ACTREFS_AGENCY,ACTREFS_DEPT,ACTREFS_PROGRAM )
		
		INSERT INTO @tblData SELECT ('Day - '+ CONVERT(varchar(2),#tblDates.day)) AS CurrDay, Mdate,WRKDATES,ISNULL(TBLTYPE,'      Referrals to Partners') AS TBLTYPE,
		Program, ProgramCode, TotalCount,4 as ORDBY FROM #tblDates LEFT JOIN TEMPREFPART ON Mdate=WRKDATES order by Mdate
		
			-- ** CONTACTS COUNT **--
		;WITH TEMPCONTACTS AS(SELECT CASECONT_DATE AS WRKDATES,'     Contacts' AS TBLTYPE,
		dbo.Fun_GetHierarchy_Desc(3,CASECONT_AGENCY,CASECONT_DEPT,CASECONT_PROGRAM) As Program,(CASECONT_AGENCY+CASECONT_DEPT+CASECONT_PROGRAM) as ProgramCode,
		Count(*) AS TotalCount, 5 as ORDBY  FROM CASECONT WHERE 
		((Cast(CASECONT_DATE as Date) Between @TBAddStartDate AND @TBAddEndDate) OR (@TBAddStartDate IS NULL))  
		AND CASECONT_AGENCY=@DefAgency GROUP BY CASECONT_DATE,CASECONT_AGENCY,CASECONT_DEPT,CASECONT_PROGRAM )
		
		INSERT INTO @tblData SELECT ('Day - '+ CONVERT(varchar(2),#tblDates.day)) AS CurrDay, Mdate,WRKDATES,ISNULL(TBLTYPE,'     Contacts') AS TBLTYPE,
		Program, ProgramCode, TotalCount,5 as ORDBY FROM #tblDates LEFT JOIN TEMPCONTACTS ON Mdate=WRKDATES order by Mdate
		
		-- ** SERVICE PLAN COUNT **--
		;WITH TEMPSP AS( SELECT SPM_STARTDATE AS WRKDATES,'    Service Plans' AS TBLTYPE,
		dbo.Fun_GetHierarchy_Desc(3,SUBSTRING(SPM_DEF_PROGRAM,1,2),SUBSTRING(SPM_DEF_PROGRAM,3,2),SUBSTRING(SPM_DEF_PROGRAM,5,2)) As Program, 
		(SPM_DEF_PROGRAM) as ProgramCode,Count(*) AS TotalCount, 6 as ORDBY  FROM CASESPM WHERE 
		((Cast(SPM_STARTDATE as Date) Between @TBAddStartDate AND @TBAddEndDate) OR (@TBAddStartDate IS NULL)) 
		--AND SUBSTRING(SPM_DEF_PROGRAM,1,2) = @DefAgency 
		AND SPM_AGENCY = @DefAgency 
		GROUP BY SPM_STARTDATE,SPM_DEF_PROGRAM )

		INSERT INTO @tblData SELECT ('Day - '+ CONVERT(varchar(2),#tblDates.day)) AS CurrDay, Mdate,WRKDATES,ISNULL(TBLTYPE,'    Service Plans') AS TBLTYPE,
		Program, ProgramCode, TotalCount,6 as ORDBY FROM #tblDates LEFT JOIN TEMPSP ON Mdate=WRKDATES order by Mdate
		
		-- ** SERVICES COUNT **--
		;WITH TEMPSERVICES AS(  SELECT CASEACT_ACTY_DATE AS WRKDATES,'   Services' AS TBLTYPE,
		dbo.Fun_GetHierarchy_Desc(3,SUBSTRING(CASEACT_ACTY_PROG,1,2),SUBSTRING(CASEACT_ACTY_PROG,3,2),SUBSTRING(CASEACT_ACTY_PROG,5,2)) As Program, 
		(CASEACT_ACTY_PROG) as ProgramCode,
		Count(*) AS TotalCount, 7 as ORDBY  FROM CASEACT WHERE 
		((Cast(CASEACT_ACTY_DATE as Date) Between @TBAddStartDate AND @TBAddEndDate) OR (@TBAddStartDate IS NULL)) 
		--AND SUBSTRING(CASEACT_ACTY_PROG,1,2) = @DefAgency
			AND CASEACT_AGENCY = @DefAgency GROUP BY CASEACT_ACTY_DATE,CASEACT_ACTY_PROG )

		INSERT INTO @tblData SELECT ('Day - '+ CONVERT(varchar(2),#tblDates.day)) AS CurrDay, Mdate,WRKDATES,ISNULL(TBLTYPE,'   Services') AS TBLTYPE,
		Program, ProgramCode, TotalCount,7 as ORDBY FROM #tblDates LEFT JOIN TEMPSERVICES ON Mdate=WRKDATES order by Mdate
		


		-- ** OUTCOMES COUNT **--
		;WITH TEMPOUTCOME AS(  SELECT CASEMS_DATE AS WRKDATES,'  Outcomes' AS TBLTYPE,
		dbo.Fun_GetHierarchy_Desc(3,SUBSTRING(CASEMS_ACTY_PROG,1,2),SUBSTRING(CASEMS_ACTY_PROG,3,2),SUBSTRING(CASEMS_ACTY_PROG,5,2)) As Program, 
		(CASEMS_ACTY_PROG) as ProgramCode,
		Count(*) AS TotalCount, 8 as ORDBY FROM CASEMS WHERE 
		((Cast(CASEMS_DATE as Date) Between @TBAddStartDate AND @TBAddEndDate) OR (@TBAddStartDate IS NULL)) 
		--AND SUBSTRING(CASEMS_ACTY_PROG,1,2) = @DefAgency 
			AND CASEMS_AGENCY = @DefAgency GROUP BY CASEMS_DATE,CASEMS_ACTY_PROG )

		INSERT INTO @tblData SELECT ('Day - '+ CONVERT(varchar(2),#tblDates.day)) AS CurrDay, Mdate,WRKDATES,ISNULL(TBLTYPE,'  Outcomes') AS TBLTYPE,
		Program, ProgramCode, TotalCount,8 as ORDBY FROM #tblDates LEFT JOIN TEMPOUTCOME ON Mdate=WRKDATES order by Mdate
		

		-- ** ASSESMENTS COUNT **--
		;WITH TEMPASSES AS( SELECT MATASMT_SS_DATE AS WRKDATES,' Assessments' AS TBLTYPE,
		dbo.Fun_GetHierarchy_Desc(3,MATASMT_AGENCY,MATASMT_DEPT,MATASMT_PROGRAM) As Program,(MATASMT_AGENCY+MATASMT_DEPT+MATASMT_PROGRAM) as ProgramCode,
		Count(*) AS TotalCount, 9 as ORDBY FROM MATASMT WHERE 
		((Cast(MATASMT_SS_DATE as Date) Between @TBAddStartDate AND @TBAddEndDate) OR (@TBAddStartDate IS NULL)) 
		AND SUBSTRING(MATASMT_AGENCY,1,2) = @DefAgency GROUP BY MATASMT_SS_DATE,MATASMT_AGENCY,MATASMT_DEPT,MATASMT_PROGRAM )

		INSERT INTO @tblData SELECT ('Day - '+ CONVERT(varchar(2),#tblDates.day)) AS CurrDay, Mdate,WRKDATES,ISNULL(TBLTYPE,' Assessments') AS TBLTYPE,
		Program, ProgramCode, TotalCount,9 as ORDBY FROM #tblDates LEFT JOIN TEMPASSES ON Mdate=WRKDATES order by Mdate

		--SELECT ('Day - '+ CONVERT(varchar(2),#tblDates.day)) AS CurrDay, Mdate,WRKDATES,ISNULL(TBLTYPE,(SELECT TOP 1 TBLTYPE FROM @tblData)) AS TBLTYPE, 
		--Program, ProgramCode,TotalCount,ORDBY,DEP_INTAKE_PROG 
		--FROM #tblDates LEFT JOIN @tblData ON Mdate=WRKDATES
		--LEFT JOIN CASEDEP ON (DEP_AGENCY+DEP_DEPT+DEP_PROGRAM)=ProgramCode
		--ORDER BY Mdate, ORDBY
		SELECT * INTO #TEMP1 FROM @tblData

		SELECT CurrDay,#tblDates.Mdate,WRKDATES,TBLTYPE,Program, ProgramCode,TotalCount,ORDBY,DEP_INTAKE_PROG 
		FROM #tblDates LEFT JOIN #TEMP1 TM ON #tblDates.Mdate= TM.Mdate LEFT JOIN CASEDEP ON (DEP_AGENCY+DEP_DEPT+DEP_PROGRAM)=ProgramCode 
		ORDER BY TM.Mdate, ORDBY

		--SELECT CurrDay,Mdate,WRKDATES,TBLTYPE,Program, ProgramCode,TotalCount,ORDBY,DEP_INTAKE_PROG 
		--FROM @tblData  LEFT JOIN CASEDEP ON (DEP_AGENCY+DEP_DEPT+DEP_PROGRAM)=ProgramCode ORDER BY Mdate, ORDBY