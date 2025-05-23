toc.dat                                                                                             0000600 0004000 0002000 00000010165 15011534552 0014443 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        PGDMP   9                    }            PBO Praktikum    16.2    16.2     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false         �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false         �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false         �           1262    41584    PBO Praktikum    DATABASE     �   CREATE DATABASE "PBO Praktikum" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_Indonesia.1252';
    DROP DATABASE "PBO Praktikum";
                postgres    false         �            1259    41604    akun    TABLE     �   CREATE TABLE public.akun (
    id integer NOT NULL,
    username character varying NOT NULL,
    password character varying NOT NULL
);
    DROP TABLE public.akun;
       public         heap    postgres    false         �            1259    41603    akun_id_seq    SEQUENCE     �   CREATE SEQUENCE public.akun_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 "   DROP SEQUENCE public.akun_id_seq;
       public          postgres    false    216         �           0    0    akun_id_seq    SEQUENCE OWNED BY     ;   ALTER SEQUENCE public.akun_id_seq OWNED BY public.akun.id;
          public          postgres    false    215         �            1259    41613    tugas    TABLE     �   CREATE TABLE public.tugas (
    id integer NOT NULL,
    nama_tugas character varying NOT NULL,
    matakuliah character varying NOT NULL,
    deadline date NOT NULL,
    status boolean DEFAULT false
);
    DROP TABLE public.tugas;
       public         heap    postgres    false         �            1259    41612    tugas_id_seq    SEQUENCE     �   CREATE SEQUENCE public.tugas_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 #   DROP SEQUENCE public.tugas_id_seq;
       public          postgres    false    218         �           0    0    tugas_id_seq    SEQUENCE OWNED BY     =   ALTER SEQUENCE public.tugas_id_seq OWNED BY public.tugas.id;
          public          postgres    false    217         U           2604    41607    akun id    DEFAULT     b   ALTER TABLE ONLY public.akun ALTER COLUMN id SET DEFAULT nextval('public.akun_id_seq'::regclass);
 6   ALTER TABLE public.akun ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    216    215    216         V           2604    41616    tugas id    DEFAULT     d   ALTER TABLE ONLY public.tugas ALTER COLUMN id SET DEFAULT nextval('public.tugas_id_seq'::regclass);
 7   ALTER TABLE public.tugas ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    217    218    218         �          0    41604    akun 
   TABLE DATA           6   COPY public.akun (id, username, password) FROM stdin;
    public          postgres    false    216       4842.dat �          0    41613    tugas 
   TABLE DATA           M   COPY public.tugas (id, nama_tugas, matakuliah, deadline, status) FROM stdin;
    public          postgres    false    218       4844.dat �           0    0    akun_id_seq    SEQUENCE SET     9   SELECT pg_catalog.setval('public.akun_id_seq', 3, true);
          public          postgres    false    215         �           0    0    tugas_id_seq    SEQUENCE SET     ;   SELECT pg_catalog.setval('public.tugas_id_seq', 17, true);
          public          postgres    false    217         Y           2606    41611    akun akun_username_key 
   CONSTRAINT     U   ALTER TABLE ONLY public.akun
    ADD CONSTRAINT akun_username_key UNIQUE (username);
 @   ALTER TABLE ONLY public.akun DROP CONSTRAINT akun_username_key;
       public            postgres    false    216                                                                                                                                                                                                                                                                                                                                                                                                                   4842.dat                                                                                            0000600 0004000 0002000 00000000005 15011534552 0014247 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        \.


                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           4844.dat                                                                                            0000600 0004000 0002000 00000000005 15011534552 0014251 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        \.


                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           restore.sql                                                                                         0000600 0004000 0002000 00000007743 15011534552 0015400 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        --
-- NOTE:
--
-- File paths need to be edited. Search for $$PATH$$ and
-- replace it with the path to the directory containing
-- the extracted data files.
--
--
-- PostgreSQL database dump
--

-- Dumped from database version 16.2
-- Dumped by pg_dump version 16.2

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

DROP DATABASE "PBO Praktikum";
--
-- Name: PBO Praktikum; Type: DATABASE; Schema: -; Owner: postgres
--

CREATE DATABASE "PBO Praktikum" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_Indonesia.1252';


ALTER DATABASE "PBO Praktikum" OWNER TO postgres;

\connect -reuse-previous=on "dbname='PBO Praktikum'"

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

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: akun; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.akun (
    id integer NOT NULL,
    username character varying NOT NULL,
    password character varying NOT NULL
);


ALTER TABLE public.akun OWNER TO postgres;

--
-- Name: akun_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.akun_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.akun_id_seq OWNER TO postgres;

--
-- Name: akun_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.akun_id_seq OWNED BY public.akun.id;


--
-- Name: tugas; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tugas (
    id integer NOT NULL,
    nama_tugas character varying NOT NULL,
    matakuliah character varying NOT NULL,
    deadline date NOT NULL,
    status boolean DEFAULT false
);


ALTER TABLE public.tugas OWNER TO postgres;

--
-- Name: tugas_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tugas_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tugas_id_seq OWNER TO postgres;

--
-- Name: tugas_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tugas_id_seq OWNED BY public.tugas.id;


--
-- Name: akun id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.akun ALTER COLUMN id SET DEFAULT nextval('public.akun_id_seq'::regclass);


--
-- Name: tugas id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tugas ALTER COLUMN id SET DEFAULT nextval('public.tugas_id_seq'::regclass);


--
-- Data for Name: akun; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.akun (id, username, password) FROM stdin;
\.
COPY public.akun (id, username, password) FROM '$$PATH$$/4842.dat';

--
-- Data for Name: tugas; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tugas (id, nama_tugas, matakuliah, deadline, status) FROM stdin;
\.
COPY public.tugas (id, nama_tugas, matakuliah, deadline, status) FROM '$$PATH$$/4844.dat';

--
-- Name: akun_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.akun_id_seq', 3, true);


--
-- Name: tugas_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tugas_id_seq', 17, true);


--
-- Name: akun akun_username_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.akun
    ADD CONSTRAINT akun_username_key UNIQUE (username);


--
-- PostgreSQL database dump complete
--

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             