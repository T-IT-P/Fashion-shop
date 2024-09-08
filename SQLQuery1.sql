create table users
(
  id_user INT primary key identity(1,1),
  username_user varchar(max) NULL,
  password_user varchar(max) NULL,
  role_user varchar(max) NULL,
  status_user varchar(max) NULL,
  date_user date NULL,
  )
