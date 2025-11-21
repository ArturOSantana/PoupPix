-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 21/11/2025 às 18:31
-- Versão do servidor: 10.4.32-MariaDB
-- Versão do PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `pouppix`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `categoria_objetivo`
--

CREATE TABLE `categoria_objetivo` (
  `id_cat` int(11) NOT NULL,
  `nome_categoria` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `cofre`
--

CREATE TABLE `cofre` (
  `id_cofre` int(11) NOT NULL,
  `usuario_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `deposito_cofre`
--

CREATE TABLE `deposito_cofre` (
  `id_dep` int(11) NOT NULL,
  `cofre_id` int(11) NOT NULL,
  `valor_depositado` decimal(10,2) NOT NULL,
  `data_deposito` datetime NOT NULL,
  `observacao` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `gasto`
--

CREATE TABLE `gasto` (
  `id_gasto` int(11) NOT NULL,
  `usuario_id` int(11) NOT NULL,
  `tipo_id` int(11) NOT NULL,
  `nome_gasto` varchar(100) NOT NULL,
  `valor_gasto` decimal(10,2) NOT NULL,
  `data_gasto` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `objetivo`
--

CREATE TABLE `objetivo` (
  `id_obj` int(11) NOT NULL,
  `usuario_id` int(11) NOT NULL,
  `categoria_id` int(11) NOT NULL,
  `nome_obj` varchar(60) NOT NULL,
  `valor_obj` decimal(10,2) NOT NULL,
  `data_criacao` date NOT NULL,
  `data_limite` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `receita`
--

CREATE TABLE `receita` (
  `id_receita` int(11) NOT NULL,
  `usuario_id` int(11) NOT NULL,
  `descricao` varchar(120) NOT NULL,
  `valor` decimal(10,2) NOT NULL,
  `data_receita` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `receita`
--

INSERT INTO `receita` (`id_receita`, `usuario_id`, `descricao`, `valor`, `data_receita`) VALUES
(1, 4, 'Salario', 200.00, '2025-11-21'),
(2, 4, 'Homologação', 1920.00, '2025-11-21');

-- --------------------------------------------------------

--
-- Estrutura para tabela `retirada_cofre`
--

CREATE TABLE `retirada_cofre` (
  `id_ret` int(11) NOT NULL,
  `cofre_id` int(11) NOT NULL,
  `valor_ret` decimal(10,2) NOT NULL,
  `data_retirada` datetime NOT NULL,
  `observacao` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `tipo_gasto`
--

CREATE TABLE `tipo_gasto` (
  `id_tipo` int(11) NOT NULL,
  `nome_tipo` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `tipo_gasto`
--

INSERT INTO `tipo_gasto` (`id_tipo`, `nome_tipo`) VALUES
(1, 'Moradia'),
(2, 'Alimenta??o'),
(3, 'Transporte'),
(4, 'Saude'),
(5, 'Lazer'),
(6, 'Educa??o');

-- --------------------------------------------------------

--
-- Estrutura para tabela `usuario`
--

CREATE TABLE `usuario` (
  `id_usuario` int(11) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `senha` varchar(100) NOT NULL,
  `email` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `categoria_objetivo`
--
ALTER TABLE `categoria_objetivo`
  ADD PRIMARY KEY (`id_cat`);

--
-- Índices de tabela `cofre`
--
ALTER TABLE `cofre`
  ADD PRIMARY KEY (`id_cofre`),
  ADD KEY `fk_cofre_usuario` (`usuario_id`);

--
-- Índices de tabela `deposito_cofre`
--
ALTER TABLE `deposito_cofre`
  ADD PRIMARY KEY (`id_dep`),
  ADD KEY `fk_deposito_cofre` (`cofre_id`);

--
-- Índices de tabela `gasto`
--
ALTER TABLE `gasto`
  ADD PRIMARY KEY (`id_gasto`),
  ADD KEY `fk_gasto_usuario` (`usuario_id`),
  ADD KEY `fk_gasto_tipo` (`tipo_id`);

--
-- Índices de tabela `objetivo`
--
ALTER TABLE `objetivo`
  ADD PRIMARY KEY (`id_obj`),
  ADD KEY `fk_obj_usuario` (`usuario_id`),
  ADD KEY `fk_obj_categoria` (`categoria_id`);

--
-- Índices de tabela `receita`
--
ALTER TABLE `receita`
  ADD PRIMARY KEY (`id_receita`),
  ADD KEY `fk_receita_usuario` (`usuario_id`);

--
-- Índices de tabela `retirada_cofre`
--
ALTER TABLE `retirada_cofre`
  ADD PRIMARY KEY (`id_ret`),
  ADD KEY `fk_retirada_cofre` (`cofre_id`);

--
-- Índices de tabela `tipo_gasto`
--
ALTER TABLE `tipo_gasto`
  ADD PRIMARY KEY (`id_tipo`);

--
-- Índices de tabela `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id_usuario`),
  ADD UNIQUE KEY `email` (`email`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `categoria_objetivo`
--
ALTER TABLE `categoria_objetivo`
  MODIFY `id_cat` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `cofre`
--
ALTER TABLE `cofre`
  MODIFY `id_cofre` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `deposito_cofre`
--
ALTER TABLE `deposito_cofre`
  MODIFY `id_dep` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `gasto`
--
ALTER TABLE `gasto`
  MODIFY `id_gasto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `objetivo`
--
ALTER TABLE `objetivo`
  MODIFY `id_obj` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `receita`
--
ALTER TABLE `receita`
  MODIFY `id_receita` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `retirada_cofre`
--
ALTER TABLE `retirada_cofre`
  MODIFY `id_ret` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `tipo_gasto`
--
ALTER TABLE `tipo_gasto`
  MODIFY `id_tipo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de tabela `usuario`
--
ALTER TABLE `usuario`
  MODIFY `id_usuario` int(11) NOT NULL AUTO_INCREMENT;

--
-- Restrições para tabelas despejadas
--

--
-- Restrições para tabelas `cofre`
--
ALTER TABLE `cofre`
  ADD CONSTRAINT `fk_cofre_usuario` FOREIGN KEY (`usuario_id`) REFERENCES `usuario` (`id_usuario`);

--
-- Restrições para tabelas `deposito_cofre`
--
ALTER TABLE `deposito_cofre`
  ADD CONSTRAINT `fk_deposito_cofre` FOREIGN KEY (`cofre_id`) REFERENCES `cofre` (`id_cofre`);

--
-- Restrições para tabelas `gasto`
--
ALTER TABLE `gasto`
  ADD CONSTRAINT `fk_gasto_tipo` FOREIGN KEY (`tipo_id`) REFERENCES `tipo_gasto` (`id_tipo`),
  ADD CONSTRAINT `fk_gasto_usuario` FOREIGN KEY (`usuario_id`) REFERENCES `usuario` (`id_usuario`);

--
-- Restrições para tabelas `objetivo`
--
ALTER TABLE `objetivo`
  ADD CONSTRAINT `fk_obj_categoria` FOREIGN KEY (`categoria_id`) REFERENCES `categoria_objetivo` (`id_cat`),
  ADD CONSTRAINT `fk_obj_usuario` FOREIGN KEY (`usuario_id`) REFERENCES `usuario` (`id_usuario`);

--
-- Restrições para tabelas `receita`
--
ALTER TABLE `receita`
  ADD CONSTRAINT `fk_receita_usuario` FOREIGN KEY (`usuario_id`) REFERENCES `usuario` (`id_usuario`);

--
-- Restrições para tabelas `retirada_cofre`
--
ALTER TABLE `retirada_cofre`
  ADD CONSTRAINT `fk_retirada_cofre` FOREIGN KEY (`cofre_id`) REFERENCES `cofre` (`id_cofre`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
