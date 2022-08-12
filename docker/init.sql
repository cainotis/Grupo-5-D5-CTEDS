create table movies (
	id SERIAL primary key,
	name text not null,
	update_dttm TIMESTAMPTZ default now()
);

create table platforms (
	id SERIAL primary key,
	name text not null
);

create table movies_platforms(
	movie_id int references movies(id),
	platform_id int references platforms(id),
	PRIMARY KEY (movie_id, platform_id)
);