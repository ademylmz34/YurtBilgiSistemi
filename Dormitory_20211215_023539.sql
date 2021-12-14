--
-- PostgreSQL database dump
--

-- Dumped from database version 14.0
-- Dumped by pg_dump version 14.0

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- Name: Dormitory; Type: DATABASE; Schema: -; Owner: postgres
--

CREATE DATABASE "Dormitory" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'English_United Kingdom.1252';


ALTER DATABASE "Dormitory" OWNER TO postgres;

\connect "Dormitory"

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- Name: dormitory; Type: SCHEMA; Schema: -; Owner: postgres
--

CREATE SCHEMA dormitory;


ALTER SCHEMA dormitory OWNER TO postgres;

--
-- Name: staff; Type: SCHEMA; Schema: -; Owner: postgres
--

CREATE SCHEMA staff;


ALTER SCHEMA staff OWNER TO postgres;

--
-- Name: student; Type: SCHEMA; Schema: -; Owner: postgres
--

CREATE SCHEMA student;


ALTER SCHEMA student OWNER TO postgres;

--
-- Name: addstaffsalary(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.addstaffsalary() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
   insert into "dormitory"."salaryinformation"(staffno)
   values(new.id);
   RETURN NEW;
END;
$$;


ALTER FUNCTION public.addstaffsalary() OWNER TO postgres;

--
-- Name: countemployees(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.countemployees() RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
	return (select count(*) from "staff"."staff");
END;
$$;


ALTER FUNCTION public.countemployees() OWNER TO postgres;

--
-- Name: countstudents(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.countstudents() RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
	return (select count(*) from "student"."students");
END;
$$;


ALTER FUNCTION public.countstudents() OWNER TO postgres;

--
-- Name: createpayment(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.createpayment() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
   insert into "dormitory"."payments"(studentno,totalpaid,remainingpayment)
   values(new.id,0,new.remainingpayment);
   RETURN NEW;
END;
$$;


ALTER FUNCTION public.createpayment() OWNER TO postgres;

--
-- Name: createstudentcard(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.createstudentcard() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
   insert into "student"."studentcards"(studentno,name,birthdate)
   values(new.id,new.name,new.birthdate);
   RETURN NEW;
END;
$$;


ALTER FUNCTION public.createstudentcard() OWNER TO postgres;

--
-- Name: createstudentpayment(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.createstudentpayment() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
   insert into "student"."studentpayments"(paymentno,studentno,amountpaid,date)
   values(new.id,new.studentno,0,now());
   RETURN NEW;
END;
$$;


ALTER FUNCTION public.createstudentpayment() OWNER TO postgres;

--
-- Name: decreaseroomcapacity(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.decreaseroomcapacity(_roomid integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
   update "dormitory"."rooms"  set capacity=capacity-1 where roomid=_roomid;
   RETURN 1;
END;
$$;


ALTER FUNCTION public.decreaseroomcapacity(_roomid integer) OWNER TO postgres;

--
-- Name: deletepayment(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.deletepayment() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
	delete  from "student"."studentpayments" where studentno=old.id;
    delete  from "dormitory"."payments" where studentno=old.id;
   
   RETURN old;
END;
$$;


ALTER FUNCTION public.deletepayment() OWNER TO postgres;

--
-- Name: deletesalary(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.deletesalary() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
	delete  from "staff"."staffsalaryinformation" where staffno=old.id;
    delete  from "dormitory"."salaryinformation" where staffno=old.id;
   
   RETURN old;
END;
$$;


ALTER FUNCTION public.deletesalary() OWNER TO postgres;

--
-- Name: increaseroomcapacity(integer, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.increaseroomcapacity(_roomid integer, _roomtype integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
   update "dormitory"."rooms"  set capacity=capacity+1 where roomid=_roomid and roomtype=_roomtype;
   RETURN 1;
END;
$$;


ALTER FUNCTION public.increaseroomcapacity(_roomid integer, _roomtype integer) OWNER TO postgres;

--
-- Name: numberofdoublerooms(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.numberofdoublerooms() RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
	return (select count(*) from "dormitory"."rooms" where roomtype=2);
END;
$$;


ALTER FUNCTION public.numberofdoublerooms() OWNER TO postgres;

--
-- Name: numberoffulldoublerooms(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.numberoffulldoublerooms() RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
	return (select count(*) from "studentinformation" where id=2);
END;
$$;


ALTER FUNCTION public.numberoffulldoublerooms() OWNER TO postgres;

--
-- Name: numberoffullquadrooms(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.numberoffullquadrooms() RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
	return (select count(*) from "studentinformation" where id=3);
END;
$$;


ALTER FUNCTION public.numberoffullquadrooms() OWNER TO postgres;

--
-- Name: numberoffullsinglerooms(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.numberoffullsinglerooms() RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
	return (select count(*) from "studentinformation" where id=1);
END;
$$;


ALTER FUNCTION public.numberoffullsinglerooms() OWNER TO postgres;

--
-- Name: numberoffulltriplerooms(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.numberoffulltriplerooms() RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
	return (select count(*) from "studentinformation" where id=3);
END;
$$;


ALTER FUNCTION public.numberoffulltriplerooms() OWNER TO postgres;

--
-- Name: numberofquadrooms(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.numberofquadrooms() RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
	return (select count(*) from "dormitory"."rooms" where roomtype=4);
END;
$$;


ALTER FUNCTION public.numberofquadrooms() OWNER TO postgres;

--
-- Name: numberofsinglerooms(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.numberofsinglerooms() RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
	return (select count(*) from "dormitory"."rooms" where roomtype=1);
END;
$$;


ALTER FUNCTION public.numberofsinglerooms() OWNER TO postgres;

--
-- Name: numberoftriplerooms(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.numberoftriplerooms() RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
	return (select count(*) from "dormitory"."rooms" where roomtype=3);
END;
$$;


ALTER FUNCTION public.numberoftriplerooms() OWNER TO postgres;

--
-- Name: paymentcontrol(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.paymentcontrol(_studentno integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
DECLARE
    amount decimal;
BEGIN
    amount:= (select remainingpayment from "dormitory"."payments" where studentno=_studentno);
	if amount=0 or amount<0 then
		return 1;
	else
		return 0;
    end if;
END;
$$;


ALTER FUNCTION public.paymentcontrol(_studentno integer) OWNER TO postgres;

--
-- Name: roomcontrol(integer, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.roomcontrol(_roomid integer, _roomtype integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
DECLARE
    capacity1  integer;
BEGIN
    capacity1:= (select capacity from "dormitory"."rooms" where roomtype=_roomtype and roomid=_roomid);
	
    IF _roomtype=1 and capacity1=1 THEN
		RETURN 0;
	ELSIF _roomtype=2 and capacity1=2 THEN
		RETURN 0;
	ELSIF _roomtype=3 and capacity1=3 THEN
		RETURN 0;
	ELSIF _roomtype=4 and capacity1=4 THEN
		RETURN 0;
	ELSE 
		RETURN 1;
    END IF;
	
	
END;
$$;


ALTER FUNCTION public.roomcontrol(_roomid integer, _roomtype integer) OWNER TO postgres;

--
-- Name: staffcontrol(character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.staffcontrol(_tcno character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
    IF (select count(*) from "staff"."staff" where tcno=_tcno)>0 THEN
		return 1;
	ELSE
		return 0;
    END IF;
END;
$$;


ALTER FUNCTION public.staffcontrol(_tcno character varying) OWNER TO postgres;

--
-- Name: studentcontrol(character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.studentcontrol(_tcno character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
    IF (select count(*) from "student"."students" where tcno=_tcno)>0 THEN
		return 1;
	ELSE
		return 0;
    END IF;
END;
$$;


ALTER FUNCTION public.studentcontrol(_tcno character varying) OWNER TO postgres;

--
-- Name: tolower(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.tolower() RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
   update "cities"  set cityname=lower(cityname);
   RETURN 1;
END;
$$;


ALTER FUNCTION public.tolower() OWNER TO postgres;

--
-- Name: updatepayment(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.updatepayment() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
   update "dormitory"."payments" set totalpaid=totalpaid+new.amountpaid,
   remainingpayment=remainingpayment-new.amountpaid where id=new.paymentno;
   RETURN NEW;
END;
$$;


ALTER FUNCTION public.updatepayment() OWNER TO postgres;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: blocks; Type: TABLE; Schema: dormitory; Owner: postgres
--

CREATE TABLE dormitory.blocks (
    "Id" integer NOT NULL,
    name character(1) NOT NULL
);


ALTER TABLE dormitory.blocks OWNER TO postgres;

--
-- Name: Blocks_Id_seq; Type: SEQUENCE; Schema: dormitory; Owner: postgres
--

CREATE SEQUENCE dormitory."Blocks_Id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE dormitory."Blocks_Id_seq" OWNER TO postgres;

--
-- Name: Blocks_Id_seq; Type: SEQUENCE OWNED BY; Schema: dormitory; Owner: postgres
--

ALTER SEQUENCE dormitory."Blocks_Id_seq" OWNED BY dormitory.blocks."Id";


--
-- Name: branches; Type: TABLE; Schema: dormitory; Owner: postgres
--

CREATE TABLE dormitory.branches (
    branchid integer NOT NULL,
    city integer NOT NULL,
    district integer NOT NULL
);


ALTER TABLE dormitory.branches OWNER TO postgres;

--
-- Name: Branches_BranchId_seq; Type: SEQUENCE; Schema: dormitory; Owner: postgres
--

CREATE SEQUENCE dormitory."Branches_BranchId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE dormitory."Branches_BranchId_seq" OWNER TO postgres;

--
-- Name: Branches_BranchId_seq; Type: SEQUENCE OWNED BY; Schema: dormitory; Owner: postgres
--

ALTER SEQUENCE dormitory."Branches_BranchId_seq" OWNED BY dormitory.branches.branchid;


--
-- Name: dormitories; Type: TABLE; Schema: dormitory; Owner: postgres
--

CREATE TABLE dormitory.dormitories (
    dormitoryid integer NOT NULL,
    dormitoryname text NOT NULL,
    branch integer NOT NULL,
    phonenumber character varying(20) NOT NULL
);


ALTER TABLE dormitory.dormitories OWNER TO postgres;

--
-- Name: Dormitories_DormitoryId_seq; Type: SEQUENCE; Schema: dormitory; Owner: postgres
--

CREATE SEQUENCE dormitory."Dormitories_DormitoryId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE dormitory."Dormitories_DormitoryId_seq" OWNER TO postgres;

--
-- Name: Dormitories_DormitoryId_seq; Type: SEQUENCE OWNED BY; Schema: dormitory; Owner: postgres
--

ALTER SEQUENCE dormitory."Dormitories_DormitoryId_seq" OWNED BY dormitory.dormitories.dormitoryid;


--
-- Name: roomtypes; Type: TABLE; Schema: dormitory; Owner: postgres
--

CREATE TABLE dormitory.roomtypes (
    id integer NOT NULL,
    name character varying(20) NOT NULL
);


ALTER TABLE dormitory.roomtypes OWNER TO postgres;

--
-- Name: RoomTypes_Id_seq; Type: SEQUENCE; Schema: dormitory; Owner: postgres
--

CREATE SEQUENCE dormitory."RoomTypes_Id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE dormitory."RoomTypes_Id_seq" OWNER TO postgres;

--
-- Name: RoomTypes_Id_seq; Type: SEQUENCE OWNED BY; Schema: dormitory; Owner: postgres
--

ALTER SEQUENCE dormitory."RoomTypes_Id_seq" OWNED BY dormitory.roomtypes.id;


--
-- Name: rooms; Type: TABLE; Schema: dormitory; Owner: postgres
--

CREATE TABLE dormitory.rooms (
    roomid integer NOT NULL,
    blockno integer NOT NULL,
    roomtype integer NOT NULL,
    capacity integer
);


ALTER TABLE dormitory.rooms OWNER TO postgres;

--
-- Name: Rooms_RoomId_seq; Type: SEQUENCE; Schema: dormitory; Owner: postgres
--

CREATE SEQUENCE dormitory."Rooms_RoomId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE dormitory."Rooms_RoomId_seq" OWNER TO postgres;

--
-- Name: Rooms_RoomId_seq; Type: SEQUENCE OWNED BY; Schema: dormitory; Owner: postgres
--

ALTER SEQUENCE dormitory."Rooms_RoomId_seq" OWNED BY dormitory.rooms.roomid;


--
-- Name: workofunits; Type: TABLE; Schema: dormitory; Owner: postgres
--

CREATE TABLE dormitory.workofunits (
    unitid integer NOT NULL,
    name character varying(50) NOT NULL
);


ALTER TABLE dormitory.workofunits OWNER TO postgres;

--
-- Name: WorkOfUnits_UnitId_seq; Type: SEQUENCE; Schema: dormitory; Owner: postgres
--

CREATE SEQUENCE dormitory."WorkOfUnits_UnitId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE dormitory."WorkOfUnits_UnitId_seq" OWNER TO postgres;

--
-- Name: WorkOfUnits_UnitId_seq; Type: SEQUENCE OWNED BY; Schema: dormitory; Owner: postgres
--

ALTER SEQUENCE dormitory."WorkOfUnits_UnitId_seq" OWNED BY dormitory.workofunits.unitid;


--
-- Name: payments; Type: TABLE; Schema: dormitory; Owner: postgres
--

CREATE TABLE dormitory.payments (
    id integer NOT NULL,
    studentno integer NOT NULL,
    totalpaid money NOT NULL,
    remainingpayment money NOT NULL
);


ALTER TABLE dormitory.payments OWNER TO postgres;

--
-- Name: payments_id_seq; Type: SEQUENCE; Schema: dormitory; Owner: postgres
--

CREATE SEQUENCE dormitory.payments_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE dormitory.payments_id_seq OWNER TO postgres;

--
-- Name: payments_id_seq; Type: SEQUENCE OWNED BY; Schema: dormitory; Owner: postgres
--

ALTER SEQUENCE dormitory.payments_id_seq OWNED BY dormitory.payments.id;


--
-- Name: salaryinformation; Type: TABLE; Schema: dormitory; Owner: postgres
--

CREATE TABLE dormitory.salaryinformation (
    id integer NOT NULL,
    staffno integer NOT NULL
);


ALTER TABLE dormitory.salaryinformation OWNER TO postgres;

--
-- Name: salaryinformation_id_seq; Type: SEQUENCE; Schema: dormitory; Owner: postgres
--

CREATE SEQUENCE dormitory.salaryinformation_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE dormitory.salaryinformation_id_seq OWNER TO postgres;

--
-- Name: salaryinformation_id_seq; Type: SEQUENCE OWNED BY; Schema: dormitory; Owner: postgres
--

ALTER SEQUENCE dormitory.salaryinformation_id_seq OWNED BY dormitory.salaryinformation.id;


--
-- Name: users; Type: TABLE; Schema: dormitory; Owner: postgres
--

CREATE TABLE dormitory.users (
    id integer NOT NULL,
    username character varying(50) NOT NULL,
    password character varying(50) NOT NULL
);


ALTER TABLE dormitory.users OWNER TO postgres;

--
-- Name: users_id_seq; Type: SEQUENCE; Schema: dormitory; Owner: postgres
--

CREATE SEQUENCE dormitory.users_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE dormitory.users_id_seq OWNER TO postgres;

--
-- Name: users_id_seq; Type: SEQUENCE OWNED BY; Schema: dormitory; Owner: postgres
--

ALTER SEQUENCE dormitory.users_id_seq OWNED BY dormitory.users.id;


--
-- Name: cities; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.cities (
    id integer NOT NULL,
    cityname character varying(50) NOT NULL
);


ALTER TABLE public.cities OWNER TO postgres;

--
-- Name: Cities_Id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Cities_Id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Cities_Id_seq" OWNER TO postgres;

--
-- Name: Cities_Id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Cities_Id_seq" OWNED BY public.cities.id;


--
-- Name: districts; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.districts (
    id integer NOT NULL,
    districtname character varying(50) NOT NULL,
    cityno integer NOT NULL
);


ALTER TABLE public.districts OWNER TO postgres;

--
-- Name: Districts_Id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Districts_Id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Districts_Id_seq" OWNER TO postgres;

--
-- Name: Districts_Id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Districts_Id_seq" OWNED BY public.districts.id;


--
-- Name: persons; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.persons (
    id integer NOT NULL,
    tcno character varying(11) NOT NULL,
    name character varying(40) NOT NULL,
    lastname character varying(40) NOT NULL,
    birthdate date NOT NULL,
    city integer NOT NULL,
    district integer NOT NULL,
    address text NOT NULL,
    phonenumber character varying(20) NOT NULL,
    gender character(8) NOT NULL,
    persontype character varying(20) NOT NULL,
    dormitory integer NOT NULL
);


ALTER TABLE public.persons OWNER TO postgres;

--
-- Name: Persons_Id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Persons_Id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Persons_Id_seq" OWNER TO postgres;

--
-- Name: Persons_Id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Persons_Id_seq" OWNED BY public.persons.id;


--
-- Name: term; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.term (
    id integer NOT NULL,
    termname character varying(50) NOT NULL
);


ALTER TABLE public.term OWNER TO postgres;

--
-- Name: Term_Id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Term_Id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Term_Id_seq" OWNER TO postgres;

--
-- Name: Term_Id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Term_Id_seq" OWNED BY public.term.id;


--
-- Name: staff; Type: TABLE; Schema: staff; Owner: postgres
--

CREATE TABLE staff.staff (
    workingunit integer NOT NULL,
    startdateofwork date NOT NULL
)
INHERITS (public.persons);


ALTER TABLE staff.staff OWNER TO postgres;

--
-- Name: staffinformation; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.staffinformation AS
 SELECT staff.tcno,
    staff.name,
    staff.lastname,
    staff.birthdate,
    staff.gender,
    cities.cityname,
    districts.districtname,
    staff.address,
    staff.phonenumber,
    dormitories.dormitoryname,
    workofunits.name AS departmenname,
    staff.startdateofwork,
    staff.persontype
   FROM ((((staff.staff
     JOIN public.cities ON ((staff.city = cities.id)))
     JOIN public.districts ON ((staff.district = districts.id)))
     JOIN dormitory.dormitories ON ((staff.dormitory = dormitories.dormitoryid)))
     JOIN dormitory.workofunits ON ((staff.workingunit = workofunits.unitid)));


ALTER TABLE public.staffinformation OWNER TO postgres;

--
-- Name: staffsalaryinformation; Type: TABLE; Schema: staff; Owner: postgres
--

CREATE TABLE staff.staffsalaryinformation (
    id integer NOT NULL,
    salaryno integer NOT NULL,
    staffno integer NOT NULL,
    amountpaid money NOT NULL,
    date date NOT NULL
);


ALTER TABLE staff.staffsalaryinformation OWNER TO postgres;

--
-- Name: staffsalaries; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.staffsalaries AS
 SELECT salaryinformation.id AS salaryno,
    staff.id AS staffno,
    staff.name,
    staff.lastname,
    staffsalaryinformation.amountpaid,
    staffsalaryinformation.date
   FROM ((staff.staff
     JOIN staff.staffsalaryinformation ON ((staff.id = staffsalaryinformation.staffno)))
     JOIN dormitory.salaryinformation ON ((staffsalaryinformation.salaryno = salaryinformation.id)));


ALTER TABLE public.staffsalaries OWNER TO postgres;

--
-- Name: departmen; Type: TABLE; Schema: student; Owner: postgres
--

CREATE TABLE student.departmen (
    departmenid integer NOT NULL,
    name character varying(50) NOT NULL
);


ALTER TABLE student.departmen OWNER TO postgres;

--
-- Name: students; Type: TABLE; Schema: student; Owner: postgres
--

CREATE TABLE student.students (
    departmen integer NOT NULL,
    registrationdate date NOT NULL,
    contractenddate date NOT NULL,
    room integer NOT NULL,
    breakfast boolean NOT NULL,
    dinner boolean NOT NULL,
    term integer NOT NULL,
    remainingpayment money,
    guardianname character varying(40),
    guardianphone character varying(20)
)
INHERITS (public.persons);


ALTER TABLE student.students OWNER TO postgres;

--
-- Name: studentinformation; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.studentinformation AS
 SELECT students.tcno,
    students.name,
    students.lastname,
    students.birthdate,
    students.gender,
    cities.cityname,
    districts.districtname,
    students.address,
    students.phonenumber,
    students.guardianname,
    students.guardianphone,
    dormitories.dormitoryname,
    roomtypes.name AS roomtype,
    rooms.roomid,
    term.termname,
    departmen.name AS departmenname,
    students.breakfast,
    students.dinner,
    students.registrationdate,
    students.contractenddate,
    roomtypes.id
   FROM (((((((student.students
     JOIN public.cities ON ((students.city = cities.id)))
     JOIN public.districts ON ((students.district = districts.id)))
     JOIN dormitory.dormitories ON ((students.dormitory = dormitories.dormitoryid)))
     JOIN dormitory.rooms ON ((students.room = rooms.roomid)))
     JOIN dormitory.roomtypes ON ((rooms.roomtype = roomtypes.id)))
     JOIN public.term ON ((students.term = term.id)))
     JOIN student.departmen ON ((students.departmen = departmen.departmenid)));


ALTER TABLE public.studentinformation OWNER TO postgres;

--
-- Name: studentpayments; Type: TABLE; Schema: student; Owner: postgres
--

CREATE TABLE student.studentpayments (
    id integer NOT NULL,
    paymentno integer NOT NULL,
    studentno integer NOT NULL,
    amountpaid money NOT NULL,
    date date NOT NULL
);


ALTER TABLE student.studentpayments OWNER TO postgres;

--
-- Name: studentpaymentinformation; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.studentpaymentinformation AS
 SELECT studentpayments.id AS recordno,
    payments.id AS paymentno,
    students.tcno,
    students.id,
    students.name,
    students.lastname,
    studentpayments.amountpaid,
    studentpayments.date,
    payments.totalpaid,
    payments.remainingpayment
   FROM ((student.students
     JOIN dormitory.payments ON ((students.id = payments.studentno)))
     JOIN student.studentpayments ON ((payments.studentno = studentpayments.studentno)));


ALTER TABLE public.studentpaymentinformation OWNER TO postgres;

--
-- Name: studentrooms; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.studentrooms AS
 SELECT students.tcno,
    students.name,
    students.lastname,
    students.gender,
    students.phonenumber,
    rooms.roomid AS roomno,
    roomtypes.id AS roomtype
   FROM ((student.students
     JOIN dormitory.rooms ON ((students.room = rooms.roomid)))
     JOIN dormitory.roomtypes ON ((rooms.roomtype = roomtypes.id)));


ALTER TABLE public.studentrooms OWNER TO postgres;

--
-- Name: staffsalaryinformation_id_seq; Type: SEQUENCE; Schema: staff; Owner: postgres
--

CREATE SEQUENCE staff.staffsalaryinformation_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE staff.staffsalaryinformation_id_seq OWNER TO postgres;

--
-- Name: staffsalaryinformation_id_seq; Type: SEQUENCE OWNED BY; Schema: staff; Owner: postgres
--

ALTER SEQUENCE staff.staffsalaryinformation_id_seq OWNED BY staff.staffsalaryinformation.id;


--
-- Name: Departman_DepartmanId_seq; Type: SEQUENCE; Schema: student; Owner: postgres
--

CREATE SEQUENCE student."Departman_DepartmanId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE student."Departman_DepartmanId_seq" OWNER TO postgres;

--
-- Name: Departman_DepartmanId_seq; Type: SEQUENCE OWNED BY; Schema: student; Owner: postgres
--

ALTER SEQUENCE student."Departman_DepartmanId_seq" OWNED BY student.departmen.departmenid;


--
-- Name: studentcards; Type: TABLE; Schema: student; Owner: postgres
--

CREATE TABLE student.studentcards (
    cardno integer NOT NULL,
    studentno integer NOT NULL,
    name character varying(50) NOT NULL,
    birthdate date NOT NULL
);


ALTER TABLE student.studentcards OWNER TO postgres;

--
-- Name: StudentCards_CardNo_seq; Type: SEQUENCE; Schema: student; Owner: postgres
--

CREATE SEQUENCE student."StudentCards_CardNo_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE student."StudentCards_CardNo_seq" OWNER TO postgres;

--
-- Name: StudentCards_CardNo_seq; Type: SEQUENCE OWNED BY; Schema: student; Owner: postgres
--

ALTER SEQUENCE student."StudentCards_CardNo_seq" OWNED BY student.studentcards.cardno;


--
-- Name: studentpayments_id_seq; Type: SEQUENCE; Schema: student; Owner: postgres
--

CREATE SEQUENCE student.studentpayments_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE student.studentpayments_id_seq OWNER TO postgres;

--
-- Name: studentpayments_id_seq; Type: SEQUENCE OWNED BY; Schema: student; Owner: postgres
--

ALTER SEQUENCE student.studentpayments_id_seq OWNED BY student.studentpayments.id;


--
-- Name: blocks Id; Type: DEFAULT; Schema: dormitory; Owner: postgres
--

ALTER TABLE ONLY dormitory.blocks ALTER COLUMN "Id" SET DEFAULT nextval('dormitory."Blocks_Id_seq"'::regclass);


--
-- Name: branches branchid; Type: DEFAULT; Schema: dormitory; Owner: postgres
--

ALTER TABLE ONLY dormitory.branches ALTER COLUMN branchid SET DEFAULT nextval('dormitory."Branches_BranchId_seq"'::regclass);


--
-- Name: dormitories dormitoryid; Type: DEFAULT; Schema: dormitory; Owner: postgres
--

ALTER TABLE ONLY dormitory.dormitories ALTER COLUMN dormitoryid SET DEFAULT nextval('dormitory."Dormitories_DormitoryId_seq"'::regclass);


--
-- Name: payments id; Type: DEFAULT; Schema: dormitory; Owner: postgres
--

ALTER TABLE ONLY dormitory.payments ALTER COLUMN id SET DEFAULT nextval('dormitory.payments_id_seq'::regclass);


--
-- Name: rooms roomid; Type: DEFAULT; Schema: dormitory; Owner: postgres
--

ALTER TABLE ONLY dormitory.rooms ALTER COLUMN roomid SET DEFAULT nextval('dormitory."Rooms_RoomId_seq"'::regclass);


--
-- Name: roomtypes id; Type: DEFAULT; Schema: dormitory; Owner: postgres
--

ALTER TABLE ONLY dormitory.roomtypes ALTER COLUMN id SET DEFAULT nextval('dormitory."RoomTypes_Id_seq"'::regclass);


--
-- Name: salaryinformation id; Type: DEFAULT; Schema: dormitory; Owner: postgres
--

ALTER TABLE ONLY dormitory.salaryinformation ALTER COLUMN id SET DEFAULT nextval('dormitory.salaryinformation_id_seq'::regclass);


--
-- Name: users id; Type: DEFAULT; Schema: dormitory; Owner: postgres
--

ALTER TABLE ONLY dormitory.users ALTER COLUMN id SET DEFAULT nextval('dormitory.users_id_seq'::regclass);


--
-- Name: workofunits unitid; Type: DEFAULT; Schema: dormitory; Owner: postgres
--

ALTER TABLE ONLY dormitory.workofunits ALTER COLUMN unitid SET DEFAULT nextval('dormitory."WorkOfUnits_UnitId_seq"'::regclass);


--
-- Name: cities id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.cities ALTER COLUMN id SET DEFAULT nextval('public."Cities_Id_seq"'::regclass);


--
-- Name: districts id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.districts ALTER COLUMN id SET DEFAULT nextval('public."Districts_Id_seq"'::regclass);


--
-- Name: persons id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.persons ALTER COLUMN id SET DEFAULT nextval('public."Persons_Id_seq"'::regclass);


--
-- Name: term id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.term ALTER COLUMN id SET DEFAULT nextval('public."Term_Id_seq"'::regclass);


--
-- Name: staff id; Type: DEFAULT; Schema: staff; Owner: postgres
--

ALTER TABLE ONLY staff.staff ALTER COLUMN id SET DEFAULT nextval('public."Persons_Id_seq"'::regclass);


--
-- Name: staffsalaryinformation id; Type: DEFAULT; Schema: staff; Owner: postgres
--

ALTER TABLE ONLY staff.staffsalaryinformation ALTER COLUMN id SET DEFAULT nextval('staff.staffsalaryinformation_id_seq'::regclass);


--
-- Name: departmen departmenid; Type: DEFAULT; Schema: student; Owner: postgres
--

ALTER TABLE ONLY student.departmen ALTER COLUMN departmenid SET DEFAULT nextval('student."Departman_DepartmanId_seq"'::regclass);


--
-- Name: studentcards cardno; Type: DEFAULT; Schema: student; Owner: postgres
--

ALTER TABLE ONLY student.studentcards ALTER COLUMN cardno SET DEFAULT nextval('student."StudentCards_CardNo_seq"'::regclass);


--
-- Name: studentpayments id; Type: DEFAULT; Schema: student; Owner: postgres
--

ALTER TABLE ONLY student.studentpayments ALTER COLUMN id SET DEFAULT nextval('student.studentpayments_id_seq'::regclass);


--
-- Name: students id; Type: DEFAULT; Schema: student; Owner: postgres
--

ALTER TABLE ONLY student.students ALTER COLUMN id SET DEFAULT nextval('public."Persons_Id_seq"'::regclass);


--
-- Data for Name: blocks; Type: TABLE DATA; Schema: dormitory; Owner: postgres
--

INSERT INTO dormitory.blocks VALUES
	(1, 'A'),
	(2, 'B');


--
-- Data for Name: branches; Type: TABLE DATA; Schema: dormitory; Owner: postgres
--

INSERT INTO dormitory.branches VALUES
	(1, 34, 431),
	(2, 54, 734),
	(3, 35, 480),
	(4, 67, 882),
	(5, 6, 73),
	(6, 61, 814),
	(7, 28, 358);


--
-- Data for Name: dormitories; Type: TABLE DATA; Schema: dormitory; Owner: postgres
--

INSERT INTO dormitory.dormitories VALUES
	(1, 'Dormitory Istanbul', 1, '02124879634'),
	(2, 'Dormitory Sakarya', 2, '02124763754'),
	(3, 'Dormitory Izmir', 3, '02125562535'),
	(4, 'Dormitory Zonguldak', 4, '02124787867'),
	(5, 'Dormitory Ankara', 5, '02127962806'),
	(6, 'Dormitory Trabzon', 6, '02126327161'),
	(7, 'Dormitory Giresun', 7, '02121853828');


--
-- Data for Name: payments; Type: TABLE DATA; Schema: dormitory; Owner: postgres
--

INSERT INTO dormitory.payments VALUES
	(6, 15, '£0.00', '£15,000.00'),
	(7, 16, '£0.00', '£20,000.00'),
	(9, 21, '£6,774.00', '£13,226.00'),
	(10, 25, '£0.00', '£7,000.00'),
	(11, 27, '£0.00', '£7,000.00'),
	(12, 28, '£1,500.00', '£13,500.00'),
	(13, 30, '£0.00', '£10,000.00'),
	(14, 31, '£0.00', '£10,000.00');


--
-- Data for Name: rooms; Type: TABLE DATA; Schema: dormitory; Owner: postgres
--

INSERT INTO dormitory.rooms VALUES
	(4, 1, 1, 0),
	(5, 1, 1, 0),
	(6, 1, 1, 0),
	(7, 1, 1, 0),
	(8, 1, 1, 0),
	(10, 1, 1, 0),
	(11, 1, 1, 0),
	(12, 1, 1, 0),
	(14, 1, 1, 0),
	(13, 1, 1, 0),
	(15, 1, 1, 0),
	(16, 1, 1, 0),
	(17, 1, 1, 0),
	(18, 1, 1, 0),
	(20, 1, 1, 0),
	(21, 1, 1, 0),
	(23, 1, 1, 0),
	(24, 1, 1, 0),
	(27, 1, 2, 0),
	(25, 1, 1, 0),
	(28, 1, 2, 0),
	(29, 1, 2, 0),
	(30, 1, 2, 0),
	(32, 1, 2, 0),
	(34, 1, 2, 0),
	(35, 1, 2, 0),
	(36, 1, 2, 0),
	(37, 1, 2, 0),
	(38, 1, 2, 0),
	(39, 1, 2, 0),
	(40, 1, 2, 0),
	(41, 1, 2, 0),
	(42, 1, 2, 0),
	(44, 1, 2, 0),
	(45, 1, 2, 0),
	(47, 1, 2, 0),
	(48, 1, 2, 0),
	(49, 1, 2, 0),
	(50, 1, 2, 0),
	(54, 1, 3, 0),
	(56, 1, 3, 0),
	(57, 1, 3, 0),
	(58, 1, 3, 0),
	(55, 1, 3, 0),
	(59, 1, 3, 0),
	(60, 1, 3, 0),
	(61, 1, 3, 0),
	(63, 1, 3, 0),
	(62, 1, 3, 0),
	(65, 1, 3, 0),
	(66, 1, 3, 0),
	(67, 1, 3, 0),
	(69, 1, 3, 0),
	(68, 1, 3, 0),
	(71, 1, 3, 0),
	(70, 1, 3, 0),
	(72, 1, 3, 0),
	(73, 1, 3, 0),
	(74, 1, 3, 0),
	(77, 1, 4, 0),
	(78, 1, 4, 0),
	(79, 1, 4, 0),
	(80, 1, 4, 0),
	(81, 1, 4, 0),
	(82, 1, 4, 0),
	(85, 1, 4, 0),
	(86, 1, 4, 0),
	(84, 1, 4, 0),
	(87, 1, 4, 0),
	(88, 1, 4, 0),
	(89, 1, 4, 0),
	(90, 1, 4, 0),
	(91, 1, 4, 0),
	(92, 1, 4, 0),
	(93, 1, 4, 0),
	(94, 1, 4, 0),
	(95, 1, 4, 0),
	(96, 1, 4, 0),
	(98, 1, 4, 0),
	(99, 1, 4, 0),
	(100, 1, 4, 0),
	(105, 2, 1, 0),
	(106, 2, 1, 0),
	(107, 2, 1, 0),
	(109, 2, 1, 0),
	(110, 2, 1, 0),
	(111, 2, 1, 0),
	(112, 2, 1, 0),
	(113, 2, 1, 0),
	(114, 2, 1, 0),
	(115, 2, 1, 0),
	(116, 2, 1, 0),
	(117, 2, 1, 0),
	(9, 1, 1, 0),
	(22, 1, 1, 0),
	(31, 1, 2, 0),
	(33, 1, 2, 0),
	(53, 1, 3, 0),
	(64, 1, 3, 0),
	(75, 1, 3, 0),
	(83, 1, 4, 0),
	(97, 1, 4, 0),
	(108, 2, 1, 0),
	(118, 2, 1, 0),
	(119, 2, 1, 0),
	(120, 2, 1, 0),
	(121, 2, 1, 0),
	(122, 2, 1, 0),
	(123, 2, 1, 0),
	(124, 2, 1, 0),
	(125, 2, 1, 0),
	(126, 2, 2, 0),
	(127, 2, 2, 0),
	(128, 2, 2, 0),
	(129, 2, 2, 0),
	(130, 2, 2, 0),
	(131, 2, 2, 0),
	(132, 2, 2, 0),
	(133, 2, 2, 0),
	(134, 2, 2, 0),
	(135, 2, 2, 0),
	(136, 2, 2, 0),
	(138, 2, 2, 0),
	(137, 2, 2, 0),
	(139, 2, 2, 0),
	(141, 2, 2, 0),
	(140, 2, 2, 0),
	(142, 2, 2, 0),
	(143, 2, 2, 0),
	(145, 2, 2, 0),
	(144, 2, 2, 0),
	(146, 2, 2, 0),
	(147, 2, 2, 0),
	(148, 2, 2, 0),
	(149, 2, 2, 0),
	(150, 2, 2, 0),
	(151, 2, 3, 0),
	(152, 2, 3, 0),
	(153, 2, 3, 0),
	(154, 2, 3, 0),
	(155, 2, 3, 0),
	(156, 2, 3, 0),
	(157, 2, 3, 0),
	(158, 2, 3, 0),
	(159, 2, 3, 0),
	(160, 2, 3, 0),
	(161, 2, 3, 0),
	(162, 2, 3, 0),
	(163, 2, 3, 0),
	(164, 2, 3, 0),
	(165, 2, 3, 0),
	(166, 2, 3, 0),
	(167, 2, 3, 0),
	(168, 2, 3, 0),
	(169, 2, 3, 0),
	(170, 2, 3, 0),
	(171, 2, 3, 0),
	(172, 2, 3, 0),
	(173, 2, 3, 0),
	(174, 2, 3, 0),
	(175, 2, 3, 0),
	(176, 2, 4, 0),
	(177, 2, 4, 0),
	(178, 2, 4, 0),
	(179, 2, 4, 0),
	(180, 2, 4, 0),
	(181, 2, 4, 0),
	(182, 2, 4, 0),
	(183, 2, 4, 0),
	(184, 2, 4, 0),
	(185, 2, 4, 0),
	(186, 2, 4, 0),
	(26, 1, 2, 1),
	(101, 2, 1, 0),
	(103, 2, 1, 0),
	(102, 2, 1, 0),
	(51, 1, 3, 0),
	(46, 1, 2, 0),
	(104, 2, 1, 1),
	(3, 1, 1, 1),
	(76, 1, 4, 1),
	(43, 1, 2, 1),
	(52, 1, 3, 2),
	(187, 2, 4, 0),
	(188, 2, 4, 0),
	(189, 2, 4, 0),
	(190, 2, 4, 0),
	(191, 2, 4, 0),
	(192, 2, 4, 0),
	(193, 2, 4, 0),
	(194, 2, 4, 0),
	(195, 2, 4, 0),
	(196, 2, 4, 0),
	(197, 2, 4, 0),
	(198, 2, 4, 0),
	(199, 2, 4, 0),
	(200, 2, 4, 0),
	(1, 1, 1, 0),
	(19, 1, 1, 1),
	(2, 1, 1, 0);


--
-- Data for Name: roomtypes; Type: TABLE DATA; Schema: dormitory; Owner: postgres
--

INSERT INTO dormitory.roomtypes VALUES
	(1, 'Single Rooms'),
	(2, 'Double Rooms'),
	(3, 'Triple Rooms'),
	(4, 'Quad Rooms');


--
-- Data for Name: salaryinformation; Type: TABLE DATA; Schema: dormitory; Owner: postgres
--

INSERT INTO dormitory.salaryinformation VALUES
	(2, 24),
	(3, 26),
	(4, 29);


--
-- Data for Name: users; Type: TABLE DATA; Schema: dormitory; Owner: postgres
--

INSERT INTO dormitory.users VALUES
	(1, 'adem28', '123');


--
-- Data for Name: workofunits; Type: TABLE DATA; Schema: dormitory; Owner: postgres
--

INSERT INTO dormitory.workofunits VALUES
	(1, 'Human Resources'),
	(2, 'Accounting'),
	(3, 'Housekeeping'),
	(4, 'Mechanic'),
	(5, 'Electrician'),
	(6, 'Management'),
	(7, 'IT'),
	(8, 'Student Administration Office'),
	(9, 'Security');


--
-- Data for Name: cities; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.cities VALUES
	(1, 'adana'),
	(2, 'adıyaman'),
	(3, 'afyonkarahisar'),
	(4, 'ağrı'),
	(5, 'amasya'),
	(6, 'ankara'),
	(7, 'antalya'),
	(8, 'artvin'),
	(9, 'aydın'),
	(10, 'balıkesir'),
	(11, 'bilecik'),
	(12, 'bingöl'),
	(13, 'bitlis'),
	(14, 'bolu'),
	(15, 'burdur'),
	(16, 'bursa'),
	(17, 'çanakkale'),
	(18, 'çankırı'),
	(19, 'çorum'),
	(20, 'denizli'),
	(21, 'diyarbakır'),
	(22, 'edirne'),
	(23, 'elazığ'),
	(24, 'erzincan'),
	(25, 'erzurum'),
	(26, 'eskişehir'),
	(27, 'gaziantep'),
	(28, 'giresun'),
	(29, 'gümüşhane'),
	(30, 'hakkari'),
	(31, 'hatay'),
	(32, 'isparta'),
	(33, 'mersin'),
	(34, 'İstanbul'),
	(35, 'İzmir'),
	(36, 'kars'),
	(37, 'kastamonu'),
	(38, 'kayseri'),
	(39, 'kırklareli'),
	(40, 'kırşehir'),
	(41, 'kocaeli'),
	(42, 'konya'),
	(43, 'kütahya'),
	(44, 'malatya'),
	(45, 'manisa'),
	(46, 'kahramanmaraş'),
	(47, 'mardin'),
	(48, 'muğla'),
	(49, 'muş'),
	(50, 'nevşehir'),
	(51, 'niğde'),
	(52, 'ordu'),
	(53, 'rize'),
	(54, 'sakarya'),
	(55, 'samsun'),
	(56, 'siirt'),
	(57, 'sinop'),
	(58, 'sivas'),
	(59, 'tekirdağ'),
	(60, 'tokat'),
	(61, 'trabzon'),
	(62, 'tunceli'),
	(63, 'şanlıurfa'),
	(64, 'uşak'),
	(65, 'van'),
	(66, 'yozgat'),
	(67, 'zonguldak'),
	(68, 'aksaray'),
	(69, 'bayburt'),
	(70, 'karaman'),
	(71, 'kırıkkale'),
	(72, 'batman'),
	(73, 'şırnak'),
	(74, 'bartın'),
	(75, 'ardahan'),
	(76, 'iğdır'),
	(77, 'yalova'),
	(78, 'karabük'),
	(79, 'kilis'),
	(80, 'osmaniye'),
	(81, 'düzce');


--
-- Data for Name: districts; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.districts VALUES
	(1, 'Seyhan', 1),
	(2, 'Ceyhan', 1),
	(3, 'Feke', 1),
	(4, 'Karaisalı', 1),
	(5, 'Karataş', 1),
	(6, 'Kozan', 1),
	(7, 'Pozantı', 1),
	(8, 'Saimbeyli', 1),
	(9, 'Tufanbeyli', 1),
	(10, 'Yumurtalık', 1),
	(11, 'Yüreğir', 1),
	(12, 'Aladağ', 1),
	(13, 'İmamoğlu', 1),
	(14, 'Sarıçam', 1),
	(15, 'Çukurova', 1),
	(16, 'Adıyaman Merkez', 2),
	(17, 'Besni', 2),
	(18, 'Çelikhan', 2),
	(19, 'Gerger', 2),
	(20, 'Gölbaşı / Adıyaman', 2),
	(21, 'Kahta', 2),
	(22, 'Samsat', 2),
	(23, 'Sincik', 2),
	(24, 'Tut', 2),
	(25, 'Afyonkarahisar Merkez', 3),
	(26, 'Bolvadin', 3),
	(27, 'Çay', 3),
	(28, 'Dazkırı', 3),
	(29, 'Dinar', 3),
	(30, 'Emirdağ', 3),
	(31, 'İhsaniye', 3),
	(32, 'Sandıklı', 3),
	(33, 'Sinanpaşa', 3),
	(34, 'Sultandağı', 3),
	(35, 'Şuhut', 3),
	(36, 'Başmakçı', 3),
	(37, 'Bayat / Afyonkarahisar', 3),
	(38, 'İscehisar', 3),
	(39, 'Çobanlar', 3),
	(40, 'Evciler', 3),
	(41, 'Hocalar', 3),
	(42, 'Kızılören', 3),
	(43, 'Ağrı Merkez', 4),
	(44, 'Diyadin', 4),
	(45, 'Doğubayazıt', 4),
	(46, 'Eleşkirt', 4),
	(47, 'Hamur', 4),
	(48, 'Patnos', 4),
	(49, 'Taşlıçay', 4),
	(50, 'Tutak', 4),
	(51, 'Amasya Merkez', 5),
	(52, 'Göynücek', 5),
	(53, 'Gümüşhacıköy', 5),
	(54, 'Merzifon', 5),
	(55, 'Suluova', 5),
	(56, 'Taşova', 5),
	(57, 'Hamamözü', 5),
	(58, 'Altındağ', 6),
	(59, 'Ayaş', 6),
	(60, 'Bala', 6),
	(61, 'Beypazarı', 6),
	(62, 'Çamlıdere', 6),
	(63, 'Çankaya', 6),
	(64, 'Çubuk', 6),
	(65, 'Elmadağ', 6),
	(66, 'Güdül', 6),
	(67, 'Haymana', 6),
	(68, 'Kalecik', 6),
	(69, 'Kızılcahamam', 6),
	(70, 'Nallıhan', 6),
	(71, 'Polatlı', 6),
	(72, 'Şereflikoçhisar', 6),
	(73, 'Yenimahalle', 6),
	(74, 'Gölbaşı / Ankara', 6),
	(75, 'Keçiören', 6),
	(76, 'Mamak', 6),
	(77, 'Sincan', 6),
	(78, 'Kazan', 6),
	(79, 'Akyurt', 6),
	(80, 'Etimesgut', 6),
	(81, 'Evren', 6),
	(82, 'Pursaklar', 6),
	(83, 'Akseki', 7),
	(84, 'Alanya', 7),
	(85, 'Elmalı', 7),
	(86, 'Finike', 7),
	(87, 'Gazipaşa', 7),
	(88, 'Gündoğmuş', 7),
	(89, 'Kaş', 7),
	(90, 'Korkuteli', 7),
	(91, 'Kumluca', 7),
	(92, 'Manavgat', 7),
	(93, 'Serik', 7),
	(94, 'Demre', 7),
	(95, 'İbradı', 7),
	(96, 'Kemer / Antalya', 7),
	(97, 'Aksu / Antalya', 7),
	(98, 'Döşemealtı', 7),
	(99, 'Kepez', 7),
	(100, 'Konyaaltı', 7),
	(101, 'Muratpaşa', 7),
	(102, 'Ardanuç', 8),
	(103, 'Arhavi', 8),
	(104, 'Artvin Merkez', 8),
	(105, 'Borçka', 8),
	(106, 'Hopa', 8),
	(107, 'Şavşat', 8),
	(108, 'Yusufeli', 8),
	(109, 'Murgul', 8),
	(110, 'Bozdoğan', 9),
	(111, 'Çine', 9),
	(112, 'Germencik', 9),
	(113, 'Karacasu', 9),
	(114, 'Koçarlı', 9),
	(115, 'Kuşadası', 9),
	(116, 'Kuyucak', 9),
	(117, 'Nazilli', 9),
	(118, 'Söke', 9),
	(119, 'Sultanhisar', 9),
	(120, 'Yenipazar / Aydın', 9),
	(121, 'Buharkent', 9),
	(122, 'İncirliova', 9),
	(123, 'Karpuzlu', 9),
	(124, 'Köşk', 9),
	(125, 'Didim', 9),
	(126, 'Efeler', 9),
	(127, 'Ayvalık', 10),
	(128, 'Balya', 10),
	(129, 'Bandırma', 10),
	(130, 'Bigadiç', 10),
	(131, 'Burhaniye', 10),
	(132, 'Dursunbey', 10),
	(133, 'Edremit / Balıkesir', 10),
	(134, 'Erdek', 10),
	(135, 'Gönen / Balıkesir', 10),
	(136, 'Havran', 10),
	(137, 'İvrindi', 10),
	(138, 'Kepsut', 10),
	(139, 'Manyas', 10),
	(140, 'Savaştepe', 10),
	(141, 'Sındırgı', 10),
	(142, 'Susurluk', 10),
	(143, 'Marmara', 10),
	(144, 'Gömeç', 10),
	(145, 'Altıeylül', 10),
	(146, 'Karesi', 10),
	(147, 'Bilecik Merkez', 11),
	(148, 'Bozüyük', 11),
	(149, 'Gölpazarı', 11),
	(150, 'Osmaneli', 11),
	(151, 'Pazaryeri', 11),
	(152, 'Söğüt', 11),
	(153, 'Yenipazar / Bilecik', 11),
	(154, 'İnhisar', 11),
	(155, 'Bingöl Merkez', 12),
	(156, 'Genç', 12),
	(157, 'Karlıova', 12),
	(158, 'Kiğı', 12),
	(159, 'Solhan', 12),
	(160, 'Adaklı', 12),
	(161, 'Yayladere', 12),
	(162, 'Yedisu', 12),
	(163, 'Adilcevaz', 13),
	(164, 'Ahlat', 13),
	(165, 'Bitlis Merkez', 13),
	(166, 'Hizan', 13),
	(167, 'Mutki', 13),
	(168, 'Tatvan', 13),
	(169, 'Güroymak', 13),
	(170, 'Bolu Merkez', 14),
	(171, 'Gerede', 14),
	(172, 'Göynük', 14),
	(173, 'Kıbrıscık', 14),
	(174, 'Mengen', 14),
	(175, 'Mudurnu', 14),
	(176, 'Seben', 14),
	(177, 'Dörtdivan', 14),
	(178, 'Yeniçağa', 14),
	(179, 'Ağlasun', 15),
	(180, 'Bucak', 15),
	(181, 'Burdur Merkez', 15),
	(182, 'Gölhisar', 15),
	(183, 'Tefenni', 15),
	(184, 'Yeşilova', 15),
	(185, 'Karamanlı', 15),
	(186, 'Kemer / Burdur', 15),
	(187, 'Altınyayla / Burdur', 15),
	(188, 'Çavdır', 15),
	(189, 'Çeltikçi', 15),
	(190, 'Gemlik', 16),
	(191, 'İnegöl', 16),
	(192, 'İznik', 16),
	(193, 'Karacabey', 16),
	(194, 'Keles', 16),
	(195, 'Mudanya', 16),
	(196, 'Mustafakemalpaşa', 16),
	(197, 'Orhaneli', 16),
	(198, 'Orhangazi', 16),
	(199, 'Yenişehir / Bursa', 16),
	(200, 'Büyükorhan', 16),
	(201, 'Harmancık', 16),
	(202, 'Nilüfer', 16),
	(203, 'Osmangazi', 16),
	(204, 'Yıldırım', 16),
	(205, 'Gürsu', 16),
	(206, 'Kestel', 16),
	(207, 'Ayvacık / Çanakkale', 17),
	(208, 'Bayramiç', 17),
	(209, 'Biga', 17),
	(210, 'Bozcaada', 17),
	(211, 'Çan', 17),
	(212, 'Çanakkale Merkez', 17),
	(213, 'Eceabat', 17),
	(214, 'Ezine', 17),
	(215, 'Gelibolu', 17),
	(216, 'Gökçeada', 17),
	(217, 'Lapseki', 17),
	(218, 'Yenice / Çanakkale', 17),
	(219, 'Çankırı Merkez', 18),
	(220, 'Çerkeş', 18),
	(221, 'Eldivan', 18),
	(222, 'Ilgaz', 18),
	(223, 'Kurşunlu', 18),
	(224, 'Orta', 18),
	(225, 'Şabanözü', 18),
	(226, 'Yapraklı', 18),
	(227, 'Atkaracalar', 18),
	(228, 'Kızılırmak', 18),
	(229, 'Bayramören', 18),
	(230, 'Korgun', 18),
	(231, 'Alaca', 19),
	(232, 'Bayat / Çorum', 19),
	(233, 'Çorum Merkez', 19),
	(234, 'İskilip', 19),
	(235, 'Kargı', 19),
	(236, 'Mecitözü', 19),
	(237, 'Ortaköy / Çorum', 19),
	(238, 'Osmancık', 19),
	(239, 'Sungurlu', 19),
	(240, 'Boğazkale', 19),
	(241, 'Uğurludağ', 19),
	(242, 'Dodurga', 19),
	(243, 'Laçin', 19),
	(244, 'Oğuzlar', 19),
	(245, 'Acıpayam', 20),
	(246, 'Buldan', 20),
	(247, 'Çal', 20),
	(248, 'Çameli', 20),
	(249, 'Çardak', 20),
	(250, 'Çivril', 20);
INSERT INTO public.districts VALUES
	(251, 'Güney', 20),
	(252, 'Kale / Denizli', 20),
	(253, 'Sarayköy', 20),
	(254, 'Tavas', 20),
	(255, 'Babadağ', 20),
	(256, 'Bekilli', 20),
	(257, 'Honaz', 20),
	(258, 'Serinhisar', 20),
	(259, 'Pamukkale', 20),
	(260, 'Baklan', 20),
	(261, 'Beyağaç', 20),
	(262, 'Bozkurt / Denizli', 20),
	(263, 'Merkezefendi', 20),
	(264, 'Bismil', 21),
	(265, 'Çermik', 21),
	(266, 'Çınar', 21),
	(267, 'Çüngüş', 21),
	(268, 'Dicle', 21),
	(269, 'Ergani', 21),
	(270, 'Hani', 21),
	(271, 'Hazro', 21),
	(272, 'Kulp', 21),
	(273, 'Lice', 21),
	(274, 'Silvan', 21),
	(275, 'Eğil', 21),
	(276, 'Kocaköy', 21),
	(277, 'Bağlar', 21),
	(278, 'Kayapınar', 21),
	(279, 'Sur', 21),
	(280, 'Yenişehir / Diyarbakır', 21),
	(281, 'Edirne Merkez', 22),
	(282, 'Enez', 22),
	(283, 'Havsa', 22),
	(284, 'İpsala', 22),
	(285, 'Keşan', 22),
	(286, 'Lalapaşa', 22),
	(287, 'Meriç', 22),
	(288, 'Uzunköprü', 22),
	(289, 'Süloğlu', 22),
	(290, 'Ağın', 23),
	(291, 'Baskil', 23),
	(292, 'Elazığ Merkez', 23),
	(293, 'Karakoçan', 23),
	(294, 'Keban', 23),
	(295, 'Maden', 23),
	(296, 'Palu', 23),
	(297, 'Sivrice', 23),
	(298, 'Arıcak', 23),
	(299, 'Kovancılar', 23),
	(300, 'Alacakaya', 23),
	(301, 'Çayırlı', 24),
	(302, 'Erzincan Merkez', 24),
	(303, 'İliç', 24),
	(304, 'Kemah', 24),
	(305, 'Kemaliye', 24),
	(306, 'Refahiye', 24),
	(307, 'Tercan', 24),
	(308, 'Üzümlü', 24),
	(309, 'Otlukbeli', 24),
	(310, 'Aşkale', 25),
	(311, 'Çat', 25),
	(312, 'Hınıs', 25),
	(313, 'Horasan', 25),
	(314, 'İspir', 25),
	(315, 'Karayazı', 25),
	(316, 'Narman', 25),
	(317, 'Oltu', 25),
	(318, 'Olur', 25),
	(319, 'Pasinler', 25),
	(320, 'Şenkaya', 25),
	(321, 'Tekman', 25),
	(322, 'Tortum', 25),
	(323, 'Karaçoban', 25),
	(324, 'Uzundere', 25),
	(325, 'Pazaryolu', 25),
	(326, 'Aziziye', 25),
	(327, 'Köprüköy', 25),
	(328, 'Palandöken', 25),
	(329, 'Yakutiye', 25),
	(330, 'Çifteler', 26),
	(331, 'Mahmudiye', 26),
	(332, 'Mihalıççık', 26),
	(333, 'Sarıcakaya', 26),
	(334, 'Seyitgazi', 26),
	(335, 'Sivrihisar', 26),
	(336, 'Alpu', 26),
	(337, 'Beylikova', 26),
	(338, 'İnönü', 26),
	(339, 'Günyüzü', 26),
	(340, 'Han', 26),
	(341, 'Mihalgazi', 26),
	(342, 'Odunpazarı', 26),
	(343, 'Tepebaşı', 26),
	(344, 'Araban', 27),
	(345, 'İslahiye', 27),
	(346, 'Nizip', 27),
	(347, 'Oğuzeli', 27),
	(348, 'Yavuzeli', 27),
	(349, 'Şahinbey', 27),
	(350, 'Şehitkamil', 27),
	(351, 'Karkamış', 27),
	(352, 'Nurdağı', 27),
	(353, 'Alucra', 28),
	(354, 'Bulancak', 28),
	(355, 'Dereli', 28),
	(356, 'Espiye', 28),
	(357, 'Eynesil', 28),
	(358, 'Giresun Merkez', 28),
	(359, 'Görele', 28),
	(360, 'Keşap', 28),
	(361, 'Şebinkarahisar', 28),
	(362, 'Tirebolu', 28),
	(363, 'Piraziz', 28),
	(364, 'Yağlıdere', 28),
	(365, 'Çamoluk', 28),
	(366, 'Çanakçı', 28),
	(367, 'Doğankent', 28),
	(368, 'Güce', 28),
	(369, 'Gümüşhane Merkez', 29),
	(370, 'Kelkit', 29),
	(371, 'Şiran', 29),
	(372, 'Torul', 29),
	(373, 'Köse', 29),
	(374, 'Kürtün', 29),
	(375, 'Çukurca', 30),
	(376, 'Hakkari Merkez', 30),
	(377, 'Şemdinli', 30),
	(378, 'Yüksekova', 30),
	(379, 'Altınözü', 31),
	(380, 'Dörtyol', 31),
	(381, 'Hassa', 31),
	(382, 'İskenderun', 31),
	(383, 'Kırıkhan', 31),
	(384, 'Reyhanlı', 31),
	(385, 'Samandağ', 31),
	(386, 'Yayladağı', 31),
	(387, 'Erzin', 31),
	(388, 'Belen', 31),
	(389, 'Kumlu', 31),
	(390, 'Antakya', 31),
	(391, 'Arsuz', 31),
	(392, 'Defne', 31),
	(393, 'Payas', 31),
	(394, 'Atabey', 32),
	(395, 'Eğirdir', 32),
	(396, 'Gelendost', 32),
	(397, 'Isparta Merkez', 32),
	(398, 'Keçiborlu', 32),
	(399, 'Senirkent', 32),
	(400, 'Sütçüler', 32),
	(401, 'Şarkikaraağaç', 32),
	(402, 'Uluborlu', 32),
	(403, 'Yalvaç', 32),
	(404, 'Aksu / Isparta', 32),
	(405, 'Gönen / Isparta', 32),
	(406, 'Yenişarbademli', 32),
	(407, 'Anamur', 33),
	(408, 'Erdemli', 33),
	(409, 'Gülnar', 33),
	(410, 'Mut', 33),
	(411, 'Silifke', 33),
	(412, 'Tarsus', 33),
	(413, 'Aydıncık / Mersin', 33),
	(414, 'Bozyazı', 33),
	(415, 'Çamlıyayla', 33),
	(416, 'Akdeniz', 33),
	(417, 'Mezitli', 33),
	(418, 'Toroslar', 33),
	(419, 'Yenişehir / Mersin', 33),
	(420, 'Adalar', 34),
	(421, 'Bakırköy', 34),
	(422, 'Beşiktaş', 34),
	(423, 'Beykoz', 34),
	(424, 'Beyoğlu', 34),
	(425, 'Çatalca', 34),
	(426, 'Eyüp', 34),
	(427, 'Fatih', 34),
	(428, 'Gaziosmanpaşa', 34),
	(429, 'Kadıköy', 34),
	(430, 'Kartal', 34),
	(431, 'Sarıyer', 34),
	(432, 'Silivri', 34),
	(433, 'Şile', 34),
	(434, 'Şişli', 34),
	(435, 'Üsküdar', 34),
	(436, 'Zeytinburnu', 34),
	(437, 'Büyükçekmece', 34),
	(438, 'Kağıthane', 34),
	(439, 'Küçükçekmece', 34),
	(440, 'Pendik', 34),
	(441, 'Ümraniye', 34),
	(442, 'Bayrampaşa', 34),
	(443, 'Avcılar', 34),
	(444, 'Bağcılar', 34),
	(445, 'Bahçelievler', 34),
	(446, 'Güngören', 34),
	(447, 'Maltepe', 34),
	(448, 'Sultanbeyli', 34),
	(449, 'Tuzla', 34),
	(450, 'Esenler', 34),
	(451, 'Arnavutköy', 34),
	(452, 'Ataşehir', 34),
	(453, 'Başakşehir', 34),
	(454, 'Beylikdüzü', 34),
	(455, 'Çekmeköy', 34),
	(456, 'Esenyurt', 34),
	(457, 'Sancaktepe', 34),
	(458, 'Sultangazi', 34),
	(459, 'Aliağa', 35),
	(460, 'Bayındır', 35),
	(461, 'Bergama', 35),
	(462, 'Bornova', 35),
	(463, 'Çeşme', 35),
	(464, 'Dikili', 35),
	(465, 'Foça', 35),
	(466, 'Karaburun', 35),
	(467, 'Karşıyaka', 35),
	(468, 'Kemalpaşa / İzmir', 35),
	(469, 'Kınık', 35),
	(470, 'Kiraz', 35),
	(471, 'Menemen', 35),
	(472, 'Ödemiş', 35),
	(473, 'Seferihisar', 35),
	(474, 'Selçuk', 35),
	(475, 'Tire', 35),
	(476, 'Torbalı', 35),
	(477, 'Urla', 35),
	(478, 'Beydağ', 35),
	(479, 'Buca', 35),
	(480, 'Konak', 35),
	(481, 'Menderes', 35),
	(482, 'Balçova', 35),
	(483, 'Çiğli', 35),
	(484, 'Gaziemir', 35),
	(485, 'Narlıdere', 35),
	(486, 'Güzelbahçe', 35),
	(487, 'Bayraklı', 35),
	(488, 'Karabağlar', 35),
	(489, 'Arpaçay', 36),
	(490, 'Digor', 36),
	(491, 'Kağızman', 36),
	(492, 'Kars Merkez', 36),
	(493, 'Sarıkamış', 36),
	(494, 'Selim', 36),
	(495, 'Susuz', 36),
	(496, 'Akyaka', 36),
	(497, 'Abana', 37),
	(498, 'Araç', 37),
	(499, 'Azdavay', 37),
	(500, 'Bozkurt / Kastamonu', 37);
INSERT INTO public.districts VALUES
	(501, 'Cide', 37),
	(502, 'Çatalzeytin', 37),
	(503, 'Daday', 37),
	(504, 'Devrekani', 37),
	(505, 'İnebolu', 37),
	(506, 'Kastamonu Merkez', 37),
	(507, 'Küre', 37),
	(508, 'Taşköprü', 37),
	(509, 'Tosya', 37),
	(510, 'İhsangazi', 37),
	(511, 'Pınarbaşı / Kastamonu', 37),
	(512, 'Şenpazar', 37),
	(513, 'Ağlı', 37),
	(514, 'Doğanyurt', 37),
	(515, 'Hanönü', 37),
	(516, 'Seydiler', 37),
	(517, 'Bünyan', 38),
	(518, 'Develi', 38),
	(519, 'Felahiye', 38),
	(520, 'İncesu', 38),
	(521, 'Pınarbaşı / Kayseri', 38),
	(522, 'Sarıoğlan', 38),
	(523, 'Sarız', 38),
	(524, 'Tomarza', 38),
	(525, 'Yahyalı', 38),
	(526, 'Yeşilhisar', 38),
	(527, 'Akkışla', 38),
	(528, 'Talas', 38),
	(529, 'Kocasinan', 38),
	(530, 'Melikgazi', 38),
	(531, 'Hacılar', 38),
	(532, 'Özvatan', 38),
	(533, 'Babaeski', 39),
	(534, 'Demirköy', 39),
	(535, 'Kırklareli Merkez', 39),
	(536, 'Kofçaz', 39),
	(537, 'Lüleburgaz', 39),
	(538, 'Pehlivanköy', 39),
	(539, 'Pınarhisar', 39),
	(540, 'Vize', 39),
	(541, 'Çiçekdağı', 40),
	(542, 'Kaman', 40),
	(543, 'Kırşehir Merkez', 40),
	(544, 'Mucur', 40),
	(545, 'Akpınar', 40),
	(546, 'Akçakent', 40),
	(547, 'Boztepe', 40),
	(548, 'Gebze', 41),
	(549, 'Gölcük', 41),
	(550, 'Kandıra', 41),
	(551, 'Karamürsel', 41),
	(552, 'Körfez', 41),
	(553, 'Derince', 41),
	(554, 'Başiskele', 41),
	(555, 'Çayırova', 41),
	(556, 'Darıca', 41),
	(557, 'Dilovası', 41),
	(558, 'İzmit', 41),
	(559, 'Kartepe', 41),
	(560, 'Akşehir', 42),
	(561, 'Beyşehir', 42),
	(562, 'Bozkır', 42),
	(563, 'Cihanbeyli', 42),
	(564, 'Çumra', 42),
	(565, 'Doğanhisar', 42),
	(566, 'Ereğli / Konya', 42),
	(567, 'Hadim', 42),
	(568, 'Ilgın', 42),
	(569, 'Kadınhanı', 42),
	(570, 'Karapınar', 42),
	(571, 'Kulu', 42),
	(572, 'Sarayönü', 42),
	(573, 'Seydişehir', 42),
	(574, 'Yunak', 42),
	(575, 'Akören', 42),
	(576, 'Altınekin', 42),
	(577, 'Derebucak', 42),
	(578, 'Hüyük', 42),
	(579, 'Karatay', 42),
	(580, 'Meram', 42),
	(581, 'Selçuklu', 42),
	(582, 'Taşkent', 42),
	(583, 'Ahırlı', 42),
	(584, 'Çeltik', 42),
	(585, 'Derbent', 42),
	(586, 'Emirgazi', 42),
	(587, 'Güneysınır', 42),
	(588, 'Halkapınar', 42),
	(589, 'Tuzlukçu', 42),
	(590, 'Yalıhüyük', 42),
	(591, 'Altıntaş', 43),
	(592, 'Domaniç', 43),
	(593, 'Emet', 43),
	(594, 'Gediz', 43),
	(595, 'Kütahya Merkez', 43),
	(596, 'Simav', 43),
	(597, 'Tavşanlı', 43),
	(598, 'Aslanapa', 43),
	(599, 'Dumlupınar', 43),
	(600, 'Hisarcık', 43),
	(601, 'Şaphane', 43),
	(602, 'Çavdarhisar', 43),
	(603, 'Pazarlar', 43),
	(604, 'Akçadağ', 44),
	(605, 'Arapgir', 44),
	(606, 'Arguvan', 44),
	(607, 'Darende', 44),
	(608, 'Doğanşehir', 44),
	(609, 'Hekimhan', 44),
	(610, 'Pütürge', 44),
	(611, 'Yeşilyurt / Malatya', 44),
	(612, 'Battalgazi', 44),
	(613, 'Doğanyol', 44),
	(614, 'Kale / Malatya', 44),
	(615, 'Kuluncak', 44),
	(616, 'Yazıhan', 44),
	(617, 'Akhisar', 45),
	(618, 'Alaşehir', 45),
	(619, 'Demirci', 45),
	(620, 'Gördes', 45),
	(621, 'Kırkağaç', 45),
	(622, 'Kula', 45),
	(623, 'Salihli', 45),
	(624, 'Sarıgöl', 45),
	(625, 'Saruhanlı', 45),
	(626, 'Selendi', 45),
	(627, 'Soma', 45),
	(628, 'Turgutlu', 45),
	(629, 'Ahmetli', 45),
	(630, 'Gölmarmara', 45),
	(631, 'Köprübaşı / Manisa', 45),
	(632, 'Şehzadeler', 45),
	(633, 'Yunusemre', 45),
	(634, 'Afşin', 46),
	(635, 'Andırın', 46),
	(636, 'Elbistan', 46),
	(637, 'Göksun', 46),
	(638, 'Pazarcık', 46),
	(639, 'Türkoğlu', 46),
	(640, 'Çağlayancerit', 46),
	(641, 'Ekinözü', 46),
	(642, 'Nurhak', 46),
	(643, 'Dulkadiroğlu', 46),
	(644, 'Onikişubat', 46),
	(645, 'Derik', 47),
	(646, 'Kızıltepe', 47),
	(647, 'Mazıdağı', 47),
	(648, 'Midyat', 47),
	(649, 'Nusaybin', 47),
	(650, 'Ömerli', 47),
	(651, 'Savur', 47),
	(652, 'Dargeçit', 47),
	(653, 'Yeşilli', 47),
	(654, 'Artuklu', 47),
	(655, 'Bodrum', 48),
	(656, 'Datça', 48),
	(657, 'Fethiye', 48),
	(658, 'Köyceğiz', 48),
	(659, 'Marmaris', 48),
	(660, 'Milas', 48),
	(661, 'Ula', 48),
	(662, 'Yatağan', 48),
	(663, 'Dalaman', 48),
	(664, 'Ortaca', 48),
	(665, 'Kavaklıdere', 48),
	(666, 'Menteşe', 48),
	(667, 'Seydikemer', 48),
	(668, 'Bulanık', 49),
	(669, 'Malazgirt', 49),
	(670, 'Muş Merkez', 49),
	(671, 'Varto', 49),
	(672, 'Hasköy', 49),
	(673, 'Korkut', 49),
	(674, 'Avanos', 50),
	(675, 'Derinkuyu', 50),
	(676, 'Gülşehir', 50),
	(677, 'Hacıbektaş', 50),
	(678, 'Kozaklı', 50),
	(679, 'Nevşehir Merkez', 50),
	(680, 'Ürgüp', 50),
	(681, 'Acıgöl', 50),
	(682, 'Bor', 51),
	(683, 'Çamardı', 51),
	(684, 'Niğde Merkez', 51),
	(685, 'Ulukışla', 51),
	(686, 'Altunhisar', 51),
	(687, 'Çiftlik', 51),
	(688, 'Akkuş', 52),
	(689, 'Aybastı', 52),
	(690, 'Fatsa', 52),
	(691, 'Gölköy', 52),
	(692, 'Korgan', 52),
	(693, 'Kumru', 52),
	(694, 'Mesudiye', 52),
	(695, 'Perşembe', 52),
	(696, 'Ulubey / Ordu', 52),
	(697, 'Ünye', 52),
	(698, 'Gülyalı', 52),
	(699, 'Gürgentepe', 52),
	(700, 'Çamaş', 52),
	(701, 'Çatalpınar', 52),
	(702, 'Çaybaşı', 52),
	(703, 'İkizce', 52),
	(704, 'Kabadüz', 52),
	(705, 'Kabataş', 52),
	(706, 'Altınordu', 52),
	(707, 'Ardeşen', 53),
	(708, 'Çamlıhemşin', 53),
	(709, 'Çayeli', 53),
	(710, 'Fındıklı', 53),
	(711, 'İkizdere', 53),
	(712, 'Kalkandere', 53),
	(713, 'Pazar / Rize', 53),
	(714, 'Rize Merkez', 53),
	(715, 'Güneysu', 53),
	(716, 'Derepazarı', 53),
	(717, 'Hemşin', 53),
	(718, 'İyidere', 53),
	(719, 'Akyazı', 54),
	(720, 'Geyve', 54),
	(721, 'Hendek', 54),
	(722, 'Karasu', 54),
	(723, 'Kaynarca', 54),
	(724, 'Sapanca', 54),
	(725, 'Kocaali', 54),
	(726, 'Pamukova', 54),
	(727, 'Taraklı', 54),
	(728, 'Ferizli', 54),
	(729, 'Karapürçek', 54),
	(730, 'Söğütlü', 54),
	(731, 'Adapazarı', 54),
	(732, 'Arifiye', 54),
	(733, 'Erenler', 54),
	(734, 'Serdivan', 54),
	(735, 'Alaçam', 55),
	(736, 'Bafra', 55),
	(737, 'Çarşamba', 55),
	(738, 'Havza', 55),
	(739, 'Kavak', 55),
	(740, 'Ladik', 55),
	(741, 'Terme', 55),
	(742, 'Vezirköprü', 55),
	(743, 'Asarcık', 55),
	(744, '19 Mayıs', 55),
	(745, 'Salıpazarı', 55),
	(746, 'Tekkeköy', 55),
	(747, 'Ayvacık / Samsun', 55),
	(748, 'Yakakent', 55),
	(749, 'Atakum', 55),
	(750, 'Canik', 55);
INSERT INTO public.districts VALUES
	(751, 'İlkadım', 55),
	(752, 'Baykan', 56),
	(753, 'Eruh', 56),
	(754, 'Kurtalan', 56),
	(755, 'Pervari', 56),
	(756, 'Siirt Merkez', 56),
	(757, 'Şirvan', 56),
	(758, 'Tillo', 56),
	(759, 'Ayancık', 57),
	(760, 'Boyabat', 57),
	(761, 'Durağan', 57),
	(762, 'Erfelek', 57),
	(763, 'Gerze', 57),
	(764, 'Sinop Merkez', 57),
	(765, 'Türkeli', 57),
	(766, 'Dikmen', 57),
	(767, 'Saraydüzü', 57),
	(768, 'Divriği', 58),
	(769, 'Gemerek', 58),
	(770, 'Gürün', 58),
	(771, 'Hafik', 58),
	(772, 'İmranlı', 58),
	(773, 'Kangal', 58),
	(774, 'Koyulhisar', 58),
	(775, 'Sivas Merkez', 58),
	(776, 'Suşehri', 58),
	(777, 'Şarkışla', 58),
	(778, 'Yıldızeli', 58),
	(779, 'Zara', 58),
	(780, 'Akıncılar', 58),
	(781, 'Altınyayla / Sivas', 58),
	(782, 'Doğanşar', 58),
	(783, 'Gölova', 58),
	(784, 'Ulaş', 58),
	(785, 'Çerkezköy', 59),
	(786, 'Çorlu', 59),
	(787, 'Hayrabolu', 59),
	(788, 'Malkara', 59),
	(789, 'Muratlı', 59),
	(790, 'Saray / Tekirdağ', 59),
	(791, 'Şarköy', 59),
	(792, 'Marmaraereğlisi', 59),
	(793, 'Ergene', 59),
	(794, 'Kapaklı', 59),
	(795, 'Süleymanpaşa', 59),
	(796, 'Almus', 60),
	(797, 'Artova', 60),
	(798, 'Erbaa', 60),
	(799, 'Niksar', 60),
	(800, 'Reşadiye', 60),
	(801, 'Tokat Merkez', 60),
	(802, 'Turhal', 60),
	(803, 'Zile', 60),
	(804, 'Pazar / Tokat', 60),
	(805, 'Yeşilyurt / Tokat', 60),
	(806, 'Başçiftlik', 60),
	(807, 'Sulusaray', 60),
	(808, 'Akçaabat', 61),
	(809, 'Araklı', 61),
	(810, 'Arsin', 61),
	(811, 'Çaykara', 61),
	(812, 'Maçka', 61),
	(813, 'Of', 61),
	(814, 'Sürmene', 61),
	(815, 'Tonya', 61),
	(816, 'Vakfıkebir', 61),
	(817, 'Yomra', 61),
	(818, 'Beşikdüzü', 61),
	(819, 'Şalpazarı', 61),
	(820, 'Çarşıbaşı', 61),
	(821, 'Dernekpazarı', 61),
	(822, 'Düzköy', 61),
	(823, 'Hayrat', 61),
	(824, 'Köprübaşı / Trabzon', 61),
	(825, 'Ortahisar', 61),
	(826, 'Çemişgezek', 62),
	(827, 'Hozat', 62),
	(828, 'Mazgirt', 62),
	(829, 'Nazımiye', 62),
	(830, 'Ovacık / Tunceli', 62),
	(831, 'Pertek', 62),
	(832, 'Pülümür', 62),
	(833, 'Tunceli Merkez', 62),
	(834, 'Akçakale', 63),
	(835, 'Birecik', 63),
	(836, 'Bozova', 63),
	(837, 'Ceylanpınar', 63),
	(838, 'Halfeti', 63),
	(839, 'Hilvan', 63),
	(840, 'Siverek', 63),
	(841, 'Suruç', 63),
	(842, 'Viranşehir', 63),
	(843, 'Harran', 63),
	(844, 'Eyyübiye', 63),
	(845, 'Haliliye', 63),
	(846, 'Karaköprü', 63),
	(847, 'Banaz', 64),
	(848, 'Eşme', 64),
	(849, 'Karahallı', 64),
	(850, 'Sivaslı', 64),
	(851, 'Ulubey / Uşak', 64),
	(852, 'Uşak Merkez', 64),
	(853, 'Başkale', 65),
	(854, 'Çatak', 65),
	(855, 'Erciş', 65),
	(856, 'Gevaş', 65),
	(857, 'Gürpınar', 65),
	(858, 'Muradiye', 65),
	(859, 'Özalp', 65),
	(860, 'Bahçesaray', 65),
	(861, 'Çaldıran', 65),
	(862, 'Edremit / Van', 65),
	(863, 'Saray / Van', 65),
	(864, 'İpekyolu', 65),
	(865, 'Tuşba', 65),
	(866, 'Akdağmadeni', 66),
	(867, 'Boğazlıyan', 66),
	(868, 'Çayıralan', 66),
	(869, 'Çekerek', 66),
	(870, 'Sarıkaya', 66),
	(871, 'Sorgun', 66),
	(872, 'Şefaatli', 66),
	(873, 'Yerköy', 66),
	(874, 'Yozgat Merkez', 66),
	(875, 'Aydıncık / Yozgat', 66),
	(876, 'Çandır', 66),
	(877, 'Kadışehri', 66),
	(878, 'Saraykent', 66),
	(879, 'Yenifakılı', 66),
	(880, 'Çaycuma', 67),
	(881, 'Devrek', 67),
	(882, 'Ereğli / Zonguldak', 67),
	(883, 'Zonguldak Merkez', 67),
	(884, 'Alaplı', 67),
	(885, 'Gökçebey', 67),
	(886, 'Kilimli', 67),
	(887, 'Kozlu', 67),
	(888, 'Aksaray Merkez', 68),
	(889, 'Ortaköy / Aksaray', 68),
	(890, 'Ağaçören', 68),
	(891, 'Güzelyurt', 68),
	(892, 'Sarıyahşi', 68),
	(893, 'Eskil', 68),
	(894, 'Gülağaç', 68),
	(895, 'Bayburt Merkez', 69),
	(896, 'Aydıntepe', 69),
	(897, 'Demirözü', 69),
	(898, 'Ermenek', 70),
	(899, 'Karaman Merkez', 70),
	(900, 'Ayrancı', 70),
	(901, 'Kazımkarabekir', 70),
	(902, 'Başyayla', 70),
	(903, 'Sarıveliler', 70),
	(904, 'Delice', 71),
	(905, 'Keskin', 71),
	(906, 'Kırıkkale Merkez', 71),
	(907, 'Sulakyurt', 71),
	(908, 'Bahşili', 71),
	(909, 'Balışeyh', 71),
	(910, 'Çelebi', 71),
	(911, 'Karakeçili', 71),
	(912, 'Yahşihan', 71),
	(913, 'Batman Merkez', 72),
	(914, 'Beşiri', 72),
	(915, 'Gercüş', 72),
	(916, 'Kozluk', 72),
	(917, 'Sason', 72),
	(918, 'Hasankeyf', 72),
	(919, 'Beytüşşebap', 73),
	(920, 'Cizre', 73),
	(921, 'İdil', 73),
	(922, 'Silopi', 73),
	(923, 'Şırnak Merkez', 73),
	(924, 'Uludere', 73),
	(925, 'Güçlükonak', 73),
	(926, 'Bartın Merkez', 74),
	(927, 'Kurucaşile', 74),
	(928, 'Ulus', 74),
	(929, 'Amasra', 74),
	(930, 'Ardahan Merkez', 75),
	(931, 'Çıldır', 75),
	(932, 'Göle', 75),
	(933, 'Hanak', 75),
	(934, 'Posof', 75),
	(935, 'Damal', 75),
	(936, 'Aralık', 76),
	(937, 'Iğdır Merkez', 76),
	(938, 'Tuzluca', 76),
	(939, 'Karakoyunlu', 76),
	(940, 'Yalova Merkez', 77),
	(941, 'Altınova', 77),
	(942, 'Armutlu', 77),
	(943, 'Çınarcık', 77),
	(944, 'Çiftlikköy', 77),
	(945, 'Termal', 77),
	(946, 'Eflani', 78),
	(947, 'Eskipazar', 78),
	(948, 'Karabük Merkez', 78),
	(949, 'Ovacık / Karabük', 78),
	(950, 'Safranbolu', 78),
	(951, 'Yenice / Karabük', 78),
	(952, 'Kilis Merkez', 79),
	(953, 'Elbeyli', 79),
	(954, 'Musabeyli', 79),
	(955, 'Polateli', 79),
	(956, 'Bahçe', 80),
	(957, 'Kadirli', 80),
	(958, 'Osmaniye Merkez', 80),
	(959, 'Düziçi', 80),
	(960, 'Hasanbeyli', 80),
	(961, 'Sumbas', 80),
	(962, 'Toprakkale', 80),
	(963, 'Akçakoca', 81),
	(964, 'Düzce Merkez', 81),
	(965, 'Yığılca', 81),
	(966, 'Cumayeri', 81),
	(967, 'Gölyaka', 81),
	(968, 'Çilimli', 81),
	(969, 'Gümüşova', 81),
	(970, 'Kaynaşlı', 81);


--
-- Data for Name: persons; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: term; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.term VALUES
	(1, '2021-2022'),
	(2, '2022-2023'),
	(3, '2023-2024'),
	(4, '2024-2025'),
	(5, '2025-2026'),
	(6, '2026-2027'),
	(7, '2027-2028'),
	(8, '2028-2029'),
	(9, '2029-2030'),
	(10, '2030-2031'),
	(11, '2031-2032'),
	(12, '2032-2033'),
	(13, '2033-2034'),
	(14, '2034-2035'),
	(15, '2035-2036'),
	(16, '2036-2037'),
	(17, '2037-2038'),
	(18, '2038-2039'),
	(19, '2039-2040'),
	(20, '2040-2041'),
	(21, '2041-2042'),
	(22, '2042-2043'),
	(23, '2043-2044'),
	(24, '2044-2045'),
	(25, '2045-2046'),
	(26, '2046-2047'),
	(27, '2047-2048'),
	(28, '2048-2049'),
	(29, '2049-2050');


--
-- Data for Name: staff; Type: TABLE DATA; Schema: staff; Owner: postgres
--

INSERT INTO staff.staff VALUES
	(24, '25488945654', 'mesut', 'yilmaz', '1976-12-14', 28, 364, 'yesilpınar merkez', '05346549823', 'Male    ', 'Manager', 6, '2021-12-14', 6),
	(26, '14564986523', 'cihan', 'yilmaz', '1986-12-14', 28, 355, 'gaziosmanpasa', '05348979464', 'Male    ', 'Staff', 1, '2021-12-14', 1),
	(29, '25315498465', 'ayse', 'yilmaz', '1987-12-15', 26, 330, 'istanbul şişli', '05489789456', 'Female  ', 'Staff', 2, '2021-12-15', 5);


--
-- Data for Name: staffsalaryinformation; Type: TABLE DATA; Schema: staff; Owner: postgres
--

INSERT INTO staff.staffsalaryinformation VALUES
	(2, 2, 24, '£7,800.00', '2021-12-14'),
	(3, 2, 24, '£5,400.00', '2022-01-15'),
	(4, 3, 26, '£4,500.00', '2021-12-14'),
	(5, 3, 26, '£4,568.00', '2022-01-20'),
	(6, 3, 26, '£4,862.00', '2021-12-14'),
	(7, 2, 24, '£4,850.00', '2021-12-14'),
	(8, 4, 29, '£4,500.00', '2021-12-15');


--
-- Data for Name: departmen; Type: TABLE DATA; Schema: student; Owner: postgres
--

INSERT INTO student.departmen VALUES
	(1, 'Computer Engineering'),
	(2, 'German Teaching'),
	(3, 'Turkish Philology'),
	(4, 'Electrical and Electronic Engineering'),
	(5, 'Mechanical Engineering '),
	(6, 'Civil Engineering'),
	(7, 'Gastronomy'),
	(8, 'German Philology'),
	(9, 'Environmental Engineering '),
	(10, 'Child Development And Training'),
	(11, 'Dentistry'),
	(12, 'Industrial Engineering'),
	(13, 'English Philology'),
	(14, 'Pharmacy'),
	(15, 'Public Relations'),
	(16, 'Architecture'),
	(17, 'Department Of Management'),
	(18, 'Interior Architecture'),
	(19, 'Department Of Mathematics'),
	(20, 'Mechatronics Engineering '),
	(21, 'Meteorological Engineering '),
	(22, 'Automotive Engineering'),
	(23, 'Psychology'),
	(24, 'Classroom Teaching'),
	(25, 'Turkish Teaching'),
	(26, 'Medical Faculty'),
	(27, 'Theatre'),
	(28, 'Aircraft Engineering'),
	(29, 'International Relations'),
	(30, 'Space Engineering'),
	(31, 'Veterinary Medicine'),
	(32, 'Software Engieering');


--
-- Data for Name: studentcards; Type: TABLE DATA; Schema: student; Owner: postgres
--

INSERT INTO student.studentcards VALUES
	(1, 27, 'vasip', '1997-12-14'),
	(2, 28, 'teoman', '1987-12-15'),
	(3, 30, 'adnan', '1997-12-15'),
	(4, 31, 'mehmet', '1999-12-15');


--
-- Data for Name: studentpayments; Type: TABLE DATA; Schema: student; Owner: postgres
--

INSERT INTO student.studentpayments VALUES
	(12, 6, 15, '£0.00', '2021-12-13'),
	(13, 7, 16, '£0.00', '2021-12-13'),
	(14, 9, 21, '£0.00', '2021-12-13'),
	(15, 9, 21, '£4,500.00', '2021-12-13'),
	(16, 9, 21, '£740.00', '2021-12-14'),
	(17, 9, 21, '£700.00', '2021-12-14'),
	(18, 9, 21, '£678.00', '2021-12-14'),
	(19, 9, 21, '£78.00', '2021-12-14'),
	(20, 9, 21, '£78.00', '2021-12-14'),
	(21, 10, 25, '£0.00', '2021-12-14'),
	(22, 11, 27, '£0.00', '2021-12-14'),
	(23, 12, 28, '£0.00', '2021-12-15'),
	(24, 12, 28, '£1,500.00', '2021-12-15'),
	(25, 13, 30, '£0.00', '2021-12-15'),
	(26, 14, 31, '£0.00', '2021-12-15');


--
-- Data for Name: students; Type: TABLE DATA; Schema: student; Owner: postgres
--

INSERT INTO student.students VALUES
	(5, '45446545645', 'adem', 'yilmaz', '1997-09-14', 28, 364, 'yesilpinar mah. tan sk. no:5 daire:2', '12345444444', 'Male    ', 'student', 18, '2021-12-13', '2021-12-13', 19, true, true, 1, 6, NULL, NULL, NULL),
	(7, '12313254564', 'sinem', 'yıldırım', '2021-12-13', 19, 231, 'dsadasasd', '46787454545', 'Female  ', 'student', 1, '2021-05-05', '2021-06-08', 101, false, true, 1, 1, NULL, NULL, NULL),
	(15, '25378945642', 'ufuk', 'özal', '1995-12-14', 20, 245, 'denizli merkez', '05347895456', 'Male    ', 'student', 12, '2021-12-13', '2022-12-13', 26, true, true, 1, 3, '£15,000.00', NULL, NULL),
	(16, '12356464564', 'asdasd', 'dsdsa', '2021-12-13', 1, 1, 'dsadsa', '54456456', 'Female  ', 'student', 1, '2021-12-13', '2021-12-13', 104, false, false, 1, 1, '£20,000.00', 'dsad', '456465'),
	(21, '45664654564', 'yılmaz', 'erdogan', '2021-12-13', 1, 1, 'dsadsa', '45646545645', 'Male    ', 'student', 1, '2021-12-13', '2021-12-13', 3, false, false, 1, 1, '£20,000.00', 'dsadsa', '78978989'),
	(25, '25897864564', 'Osman', 'Olgun', '1989-12-14', 24, 301, 'istanbul eyüp', '05368495648', 'Male    ', 'student', 7, '2021-12-14', '2022-12-15', 76, true, true, 1, 1, '£7,000.00', 'Ahmet Olgun', '05345984545'),
	(27, '12657456464', 'vasip', 'sahin', '1997-12-14', 35, 485, 'kücükcekmece', '05365897984', 'Male    ', 'student', 4, '2021-12-14', '2021-12-14', 76, true, true, 1, 1, '£7,000.00', 'ali sahin', '05346545679'),
	(28, '21646566465', 'teoman', 'koca', '1987-12-15', 61, 813, 'ankara yenimahalle', '44444444444', 'Male    ', 'student', 6, '2022-12-20', '2023-12-20', 43, false, true, 1, 6, '£15,000.00', 'abdullah koca', '05347956567'),
	(30, '16544562313', 'adnan', 'ulusoy', '1997-12-15', 61, 808, 'akcaabat', '05359464646', 'Male    ', 'student', 1, '2021-12-15', '2021-12-15', 52, false, true, 1, 1, '£10,000.00', 'idris ulusoy', '05489544564'),
	(31, '27893121644', 'mehmet', 'diler', '1999-12-15', 58, 768, 'gaziosmanpasa', '05348954313', 'Male    ', 'student', 4, '2021-12-15', '2021-12-15', 52, false, false, 1, 2, '£10,000.00', 'akif diler', '05448766456');


--
-- Name: Blocks_Id_seq; Type: SEQUENCE SET; Schema: dormitory; Owner: postgres
--

SELECT pg_catalog.setval('dormitory."Blocks_Id_seq"', 1, false);


--
-- Name: Branches_BranchId_seq; Type: SEQUENCE SET; Schema: dormitory; Owner: postgres
--

SELECT pg_catalog.setval('dormitory."Branches_BranchId_seq"', 1, false);


--
-- Name: Dormitories_DormitoryId_seq; Type: SEQUENCE SET; Schema: dormitory; Owner: postgres
--

SELECT pg_catalog.setval('dormitory."Dormitories_DormitoryId_seq"', 1, false);


--
-- Name: RoomTypes_Id_seq; Type: SEQUENCE SET; Schema: dormitory; Owner: postgres
--

SELECT pg_catalog.setval('dormitory."RoomTypes_Id_seq"', 1, false);


--
-- Name: Rooms_RoomId_seq; Type: SEQUENCE SET; Schema: dormitory; Owner: postgres
--

SELECT pg_catalog.setval('dormitory."Rooms_RoomId_seq"', 200, true);


--
-- Name: WorkOfUnits_UnitId_seq; Type: SEQUENCE SET; Schema: dormitory; Owner: postgres
--

SELECT pg_catalog.setval('dormitory."WorkOfUnits_UnitId_seq"', 1, false);


--
-- Name: payments_id_seq; Type: SEQUENCE SET; Schema: dormitory; Owner: postgres
--

SELECT pg_catalog.setval('dormitory.payments_id_seq', 14, true);


--
-- Name: salaryinformation_id_seq; Type: SEQUENCE SET; Schema: dormitory; Owner: postgres
--

SELECT pg_catalog.setval('dormitory.salaryinformation_id_seq', 4, true);


--
-- Name: users_id_seq; Type: SEQUENCE SET; Schema: dormitory; Owner: postgres
--

SELECT pg_catalog.setval('dormitory.users_id_seq', 1, true);


--
-- Name: Cities_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Cities_Id_seq"', 1, false);


--
-- Name: Districts_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Districts_Id_seq"', 1, false);


--
-- Name: Persons_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Persons_Id_seq"', 31, true);


--
-- Name: Term_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Term_Id_seq"', 1, false);


--
-- Name: staffsalaryinformation_id_seq; Type: SEQUENCE SET; Schema: staff; Owner: postgres
--

SELECT pg_catalog.setval('staff.staffsalaryinformation_id_seq', 8, true);


--
-- Name: Departman_DepartmanId_seq; Type: SEQUENCE SET; Schema: student; Owner: postgres
--

SELECT pg_catalog.setval('student."Departman_DepartmanId_seq"', 33, true);


--
-- Name: StudentCards_CardNo_seq; Type: SEQUENCE SET; Schema: student; Owner: postgres
--

SELECT pg_catalog.setval('student."StudentCards_CardNo_seq"', 4, true);


--
-- Name: studentpayments_id_seq; Type: SEQUENCE SET; Schema: student; Owner: postgres
--

SELECT pg_catalog.setval('student.studentpayments_id_seq', 26, true);


--
-- Name: blocks blockPK; Type: CONSTRAINT; Schema: dormitory; Owner: postgres
--

ALTER TABLE ONLY dormitory.blocks
    ADD CONSTRAINT "blockPK" PRIMARY KEY ("Id");


--
-- Name: blocks blockUnique; Type: CONSTRAINT; Schema: dormitory; Owner: postgres
--

ALTER TABLE ONLY dormitory.blocks
    ADD CONSTRAINT "blockUnique" UNIQUE (name);


--
-- Name: branches branchIdPK; Type: CONSTRAINT; Schema: dormitory; Owner: postgres
--

ALTER TABLE ONLY dormitory.branches
    ADD CONSTRAINT "branchIdPK" PRIMARY KEY (branchid);


--
-- Name: dormitories dormitoryIdPK; Type: CONSTRAINT; Schema: dormitory; Owner: postgres
--

ALTER TABLE ONLY dormitory.dormitories
    ADD CONSTRAINT "dormitoryIdPK" PRIMARY KEY (dormitoryid);


--
-- Name: dormitories dormitoryNameUnique; Type: CONSTRAINT; Schema: dormitory; Owner: postgres
--

ALTER TABLE ONLY dormitory.dormitories
    ADD CONSTRAINT "dormitoryNameUnique" UNIQUE (dormitoryname);


--
-- Name: payments idPK; Type: CONSTRAINT; Schema: dormitory; Owner: postgres
--

ALTER TABLE ONLY dormitory.payments
    ADD CONSTRAINT "idPK" PRIMARY KEY (id);


--
-- Name: rooms roomIdPK; Type: CONSTRAINT; Schema: dormitory; Owner: postgres
--

ALTER TABLE ONLY dormitory.rooms
    ADD CONSTRAINT "roomIdPK" PRIMARY KEY (roomid);


--
-- Name: roomtypes roomTypePK; Type: CONSTRAINT; Schema: dormitory; Owner: postgres
--

ALTER TABLE ONLY dormitory.roomtypes
    ADD CONSTRAINT "roomTypePK" PRIMARY KEY (id);


--
-- Name: roomtypes roomTypeUnique; Type: CONSTRAINT; Schema: dormitory; Owner: postgres
--

ALTER TABLE ONLY dormitory.roomtypes
    ADD CONSTRAINT "roomTypeUnique" UNIQUE (name);


--
-- Name: salaryinformation salary_idPK; Type: CONSTRAINT; Schema: dormitory; Owner: postgres
--

ALTER TABLE ONLY dormitory.salaryinformation
    ADD CONSTRAINT "salary_idPK" PRIMARY KEY (id);


--
-- Name: workofunits unitPK; Type: CONSTRAINT; Schema: dormitory; Owner: postgres
--

ALTER TABLE ONLY dormitory.workofunits
    ADD CONSTRAINT "unitPK" PRIMARY KEY (unitid);


--
-- Name: users userNameUnique; Type: CONSTRAINT; Schema: dormitory; Owner: postgres
--

ALTER TABLE ONLY dormitory.users
    ADD CONSTRAINT "userNameUnique" UNIQUE (username);


--
-- Name: users user_idPK; Type: CONSTRAINT; Schema: dormitory; Owner: postgres
--

ALTER TABLE ONLY dormitory.users
    ADD CONSTRAINT "user_idPK" PRIMARY KEY (id);


--
-- Name: workofunits workOfUnitNameUnique; Type: CONSTRAINT; Schema: dormitory; Owner: postgres
--

ALTER TABLE ONLY dormitory.workofunits
    ADD CONSTRAINT "workOfUnitNameUnique" UNIQUE (name);


--
-- Name: cities cityIdPK; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.cities
    ADD CONSTRAINT "cityIdPK" PRIMARY KEY (id);


--
-- Name: cities cityNameUnique; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.cities
    ADD CONSTRAINT "cityNameUnique" UNIQUE (cityname);


--
-- Name: districts districtIdPK; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.districts
    ADD CONSTRAINT "districtIdPK" PRIMARY KEY (id);


--
-- Name: districts districtNameUnique; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.districts
    ADD CONSTRAINT "districtNameUnique" UNIQUE (districtname);


--
-- Name: persons personIdPK; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.persons
    ADD CONSTRAINT "personIdPK" PRIMARY KEY (id);


--
-- Name: term termIdPK; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.term
    ADD CONSTRAINT "termIdPK" PRIMARY KEY (id);


--
-- Name: term termNameUnique; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.term
    ADD CONSTRAINT "termNameUnique" UNIQUE (termname);


--
-- Name: staffsalaryinformation staffSalaryPK; Type: CONSTRAINT; Schema: staff; Owner: postgres
--

ALTER TABLE ONLY staff.staffsalaryinformation
    ADD CONSTRAINT "staffSalaryPK" PRIMARY KEY (id);


--
-- Name: staff staffTcUnique; Type: CONSTRAINT; Schema: staff; Owner: postgres
--

ALTER TABLE ONLY staff.staff
    ADD CONSTRAINT "staffTcUnique" UNIQUE (tcno);


--
-- Name: staff staff_IDPK; Type: CONSTRAINT; Schema: staff; Owner: postgres
--

ALTER TABLE ONLY staff.staff
    ADD CONSTRAINT "staff_IDPK" PRIMARY KEY (id);


--
-- Name: studentcards cardNoPK; Type: CONSTRAINT; Schema: student; Owner: postgres
--

ALTER TABLE ONLY student.studentcards
    ADD CONSTRAINT "cardNoPK" PRIMARY KEY (cardno);


--
-- Name: departmen departmanPK; Type: CONSTRAINT; Schema: student; Owner: postgres
--

ALTER TABLE ONLY student.departmen
    ADD CONSTRAINT "departmanPK" PRIMARY KEY (departmenid);


--
-- Name: departmen departmanUnique; Type: CONSTRAINT; Schema: student; Owner: postgres
--

ALTER TABLE ONLY student.departmen
    ADD CONSTRAINT "departmanUnique" UNIQUE (name);


--
-- Name: students studentTcUnique; Type: CONSTRAINT; Schema: student; Owner: postgres
--

ALTER TABLE ONLY student.students
    ADD CONSTRAINT "studentTcUnique" UNIQUE (tcno);


--
-- Name: students student_IdPK; Type: CONSTRAINT; Schema: student; Owner: postgres
--

ALTER TABLE ONLY student.students
    ADD CONSTRAINT "student_IdPK" PRIMARY KEY (id);


--
-- Name: studentpayments studentpayment_idPK; Type: CONSTRAINT; Schema: student; Owner: postgres
--

ALTER TABLE ONLY student.studentpayments
    ADD CONSTRAINT "studentpayment_idPK" PRIMARY KEY (id);


--
-- Name: persontypeIndex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "persontypeIndex" ON public.persons USING btree (persontype);


--
-- Name: staffTcINDEX; Type: INDEX; Schema: staff; Owner: postgres
--

CREATE INDEX "staffTcINDEX" ON staff.staff USING btree (tcno);


--
-- Name: studentTcINDEX; Type: INDEX; Schema: student; Owner: postgres
--

CREATE INDEX "studentTcINDEX" ON student.students USING btree (tcno);


--
-- Name: payments addstudentpayment; Type: TRIGGER; Schema: dormitory; Owner: postgres
--

CREATE TRIGGER addstudentpayment AFTER INSERT ON dormitory.payments FOR EACH ROW EXECUTE FUNCTION public.createstudentpayment();


--
-- Name: staff addsalary; Type: TRIGGER; Schema: staff; Owner: postgres
--

CREATE TRIGGER addsalary AFTER INSERT ON staff.staff FOR EACH ROW EXECUTE FUNCTION public.addstaffsalary();


--
-- Name: staff dltsalary; Type: TRIGGER; Schema: staff; Owner: postgres
--

CREATE TRIGGER dltsalary BEFORE DELETE ON staff.staff FOR EACH ROW EXECUTE FUNCTION public.deletesalary();


--
-- Name: students addpayment; Type: TRIGGER; Schema: student; Owner: postgres
--

CREATE TRIGGER addpayment AFTER INSERT ON student.students FOR EACH ROW EXECUTE FUNCTION public.createpayment();


--
-- Name: students dltpayment; Type: TRIGGER; Schema: student; Owner: postgres
--

CREATE TRIGGER dltpayment BEFORE DELETE ON student.students FOR EACH ROW EXECUTE FUNCTION public.deletepayment();


--
-- Name: students studentcard; Type: TRIGGER; Schema: student; Owner: postgres
--

CREATE TRIGGER studentcard AFTER INSERT ON student.students FOR EACH ROW EXECUTE FUNCTION public.createstudentcard();


--
-- Name: studentpayments updtpayment; Type: TRIGGER; Schema: student; Owner: postgres
--

CREATE TRIGGER updtpayment AFTER INSERT ON student.studentpayments FOR EACH ROW EXECUTE FUNCTION public.updatepayment();


--
-- Name: rooms blockNofK; Type: FK CONSTRAINT; Schema: dormitory; Owner: postgres
--

ALTER TABLE ONLY dormitory.rooms
    ADD CONSTRAINT "blockNofK" FOREIGN KEY (blockno) REFERENCES dormitory.blocks("Id");


--
-- Name: branches branchCityFK; Type: FK CONSTRAINT; Schema: dormitory; Owner: postgres
--

ALTER TABLE ONLY dormitory.branches
    ADD CONSTRAINT "branchCityFK" FOREIGN KEY (city) REFERENCES public.cities(id);


--
-- Name: branches branchDistrictFK; Type: FK CONSTRAINT; Schema: dormitory; Owner: postgres
--

ALTER TABLE ONLY dormitory.branches
    ADD CONSTRAINT "branchDistrictFK" FOREIGN KEY (district) REFERENCES public.districts(id);


--
-- Name: dormitories branchFK; Type: FK CONSTRAINT; Schema: dormitory; Owner: postgres
--

ALTER TABLE ONLY dormitory.dormitories
    ADD CONSTRAINT "branchFK" FOREIGN KEY (branch) REFERENCES dormitory.branches(branchid);


--
-- Name: rooms roomTypefK; Type: FK CONSTRAINT; Schema: dormitory; Owner: postgres
--

ALTER TABLE ONLY dormitory.rooms
    ADD CONSTRAINT "roomTypefK" FOREIGN KEY (roomtype) REFERENCES dormitory.roomtypes(id);


--
-- Name: salaryinformation staffFK; Type: FK CONSTRAINT; Schema: dormitory; Owner: postgres
--

ALTER TABLE ONLY dormitory.salaryinformation
    ADD CONSTRAINT "staffFK" FOREIGN KEY (staffno) REFERENCES staff.staff(id);


--
-- Name: payments studentNo_fk; Type: FK CONSTRAINT; Schema: dormitory; Owner: postgres
--

ALTER TABLE ONLY dormitory.payments
    ADD CONSTRAINT "studentNo_fk" FOREIGN KEY (studentno) REFERENCES student.students(id);


--
-- Name: districts cityNOfK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.districts
    ADD CONSTRAINT "cityNOfK" FOREIGN KEY (cityno) REFERENCES public.cities(id);


--
-- Name: staffsalaryinformation salaryFK; Type: FK CONSTRAINT; Schema: staff; Owner: postgres
--

ALTER TABLE ONLY staff.staffsalaryinformation
    ADD CONSTRAINT "salaryFK" FOREIGN KEY (salaryno) REFERENCES dormitory.salaryinformation(id);


--
-- Name: staff staffCityFK; Type: FK CONSTRAINT; Schema: staff; Owner: postgres
--

ALTER TABLE ONLY staff.staff
    ADD CONSTRAINT "staffCityFK" FOREIGN KEY (city) REFERENCES public.cities(id);


--
-- Name: staff staffDistrictFK; Type: FK CONSTRAINT; Schema: staff; Owner: postgres
--

ALTER TABLE ONLY staff.staff
    ADD CONSTRAINT "staffDistrictFK" FOREIGN KEY (district) REFERENCES public.districts(id);


--
-- Name: staffsalaryinformation staffFK; Type: FK CONSTRAINT; Schema: staff; Owner: postgres
--

ALTER TABLE ONLY staff.staffsalaryinformation
    ADD CONSTRAINT "staffFK" FOREIGN KEY (staffno) REFERENCES staff.staff(id);


--
-- Name: staff staff_DormitoryFK; Type: FK CONSTRAINT; Schema: staff; Owner: postgres
--

ALTER TABLE ONLY staff.staff
    ADD CONSTRAINT "staff_DormitoryFK" FOREIGN KEY (dormitory) REFERENCES dormitory.dormitories(dormitoryid);


--
-- Name: staff workOfUnitFK; Type: FK CONSTRAINT; Schema: staff; Owner: postgres
--

ALTER TABLE ONLY staff.staff
    ADD CONSTRAINT "workOfUnitFK" FOREIGN KEY (workingunit) REFERENCES dormitory.workofunits(unitid);


--
-- Name: students departmanFK; Type: FK CONSTRAINT; Schema: student; Owner: postgres
--

ALTER TABLE ONLY student.students
    ADD CONSTRAINT "departmanFK" FOREIGN KEY (departmen) REFERENCES student.departmen(departmenid);


--
-- Name: studentpayments paymentnoFk; Type: FK CONSTRAINT; Schema: student; Owner: postgres
--

ALTER TABLE ONLY student.studentpayments
    ADD CONSTRAINT "paymentnoFk" FOREIGN KEY (paymentno) REFERENCES dormitory.payments(id);


--
-- Name: students roomFK; Type: FK CONSTRAINT; Schema: student; Owner: postgres
--

ALTER TABLE ONLY student.students
    ADD CONSTRAINT "roomFK" FOREIGN KEY (room) REFERENCES dormitory.rooms(roomid);


--
-- Name: students studentCityFK; Type: FK CONSTRAINT; Schema: student; Owner: postgres
--

ALTER TABLE ONLY student.students
    ADD CONSTRAINT "studentCityFK" FOREIGN KEY (city) REFERENCES public.cities(id);


--
-- Name: students studentDistrictFK; Type: FK CONSTRAINT; Schema: student; Owner: postgres
--

ALTER TABLE ONLY student.students
    ADD CONSTRAINT "studentDistrictFK" FOREIGN KEY (district) REFERENCES public.districts(id);


--
-- Name: studentcards studentFK; Type: FK CONSTRAINT; Schema: student; Owner: postgres
--

ALTER TABLE ONLY student.studentcards
    ADD CONSTRAINT "studentFK" FOREIGN KEY (studentno) REFERENCES student.students(id);


--
-- Name: studentpayments studentNofk; Type: FK CONSTRAINT; Schema: student; Owner: postgres
--

ALTER TABLE ONLY student.studentpayments
    ADD CONSTRAINT "studentNofk" FOREIGN KEY (studentno) REFERENCES student.students(id);


--
-- Name: students student_DormitoryFK; Type: FK CONSTRAINT; Schema: student; Owner: postgres
--

ALTER TABLE ONLY student.students
    ADD CONSTRAINT "student_DormitoryFK" FOREIGN KEY (dormitory) REFERENCES dormitory.dormitories(dormitoryid);


--
-- Name: students termFK; Type: FK CONSTRAINT; Schema: student; Owner: postgres
--

ALTER TABLE ONLY student.students
    ADD CONSTRAINT "termFK" FOREIGN KEY (term) REFERENCES public.term(id);


--
-- PostgreSQL database dump complete
--

