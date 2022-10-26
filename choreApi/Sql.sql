-- Active: 1666715466993@@SG-berry-server-8496-6844-mysql-master.servers.mongodirector.com@3306@SqlDb

CREATE Table
    if not exists chores(
        id VARCHAR(255) NOT NULL PRIMARY KEY,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        name VARCHAR(255) not NULL,
        value INT not NULL,
        isCompleted BOOLEAN not NULL,
        creatorId VARCHAR(255) not NULL -- Foreign Key (creatorId) REFERENCES accounts(id) on delete CASCADE
    ) -- default charset utf8 COMMENT '' 
;