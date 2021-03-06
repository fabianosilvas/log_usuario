SELECT  *
FROM [DB5599_STAGE].[dbo].[logtb001_log_sessao]


SELECT*
  FROM [DB5599_STAGE].[dbo].[logtb002_log_acesso]

  /*
	truncate table [DB5599_STAGE].[dbo].[logtb002_log_acesso]
	truncate table [DB5599_STAGE].[dbo].[logtb001_log_sessao]



CREATE TABLE [dbo].[logtb001_log_sessao](
	[dh_acesso] [datetime] NOT NULL,
	[co_sessao] [varchar](50) NOT NULL,
	[dh_ultima_requisicao] [datetime] NULL,
	[dh_saida] [datetime] NULL,
	[qt_tempo_sessao] [time](7) NULL,
	[no_usuario] [varchar](100) NULL,
	[de_navegador] [varchar](100) NULL,
	[de_resolucao] [varchar](50) NULL,
	[de_sistema_operacional] [varchar](100) NULL,
	[de_user_agent] [varchar](500) NULL,
 CONSTRAINT [PK_logtb001_log_sessao] PRIMARY KEY CLUSTERED 
(
	[dh_acesso] DESC,
	[co_sessao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]



CREATE TABLE [dbo].[logtb002_log_acesso](
	[dh_acesso] [datetime] NOT NULL,
	[co_sessao] [varchar](50) NOT NULL,
	[de_pagina] [varchar](500) NOT NULL,
	[de_pagina_origem_requisicao] [varchar](500) NULL,
 CONSTRAINT [PK_logtb002_log_acesso] PRIMARY KEY CLUSTERED 
(
	[dh_acesso] DESC,
	[co_sessao] ASC,
	[de_pagina] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


CREATE TABLE [dbo].[reatb001_resultado](
	[CO_UNIDADE] [float] NOT NULL,
	[VR_OBJETIVO] [float] NULL,
	[VR_REALIZADO] [float] NULL,
	[PC_REALIZADO] [float] NULL,
 CONSTRAINT [PK_reatb001_resultado] PRIMARY KEY CLUSTERED 
(
	[CO_UNIDADE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

  */