ALTER TABLE `tblarea` 
ADD COLUMN `ParentId` VARCHAR(128) NULL AFTER `Name`;

CREATE DEFINER=`root`@`localhost` FUNCTION `GenerateParentId`(in_id varchar(128)) RETURNS varchar(128) CHARSET utf8
BEGIN
declare parentId varchar(128);
declare pattern varchar(255);
set pattern=TRIM(TRAILING  '0' FROM in_id);
if(LENGTH(pattern)=2) then return "";
end if;
if(LENGTH(pattern)=4)then
return RPAD(left(pattern,2),6,'0');
end if;
if(LENGTH(pattern)=6)then 
return RPAD(left(pattern,4),6,'0');
end if;
RETURN "";
END

update tblarea set ParentId=GenerateParentId(id) where id in (select a.id from (select id from tblarea) as a)