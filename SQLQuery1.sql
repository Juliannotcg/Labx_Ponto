select FunId AS Id,FunNome AS Nome, EmpNomeFantasia AS Empresa, DepNomeDepartamento AS Departamento , FncNome AS Funcao
                    from FunFuncionario
                    left join EmpEmpresa ON Fun_EmpId = EmpId
                    left join FncFuncao ON Fun_FncId = FncId
                    left join DepDepartamento ON Fnc_DepId = DepId