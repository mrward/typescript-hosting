ls.refresh(true);
var hostAdapter = new TypeScript.Services.LanguageServiceShimHostAdapter(host);
var compiler = new TypeScript.Services.LanguageServiceCompiler(hostAdapter);
var emitResult = compiler.emit(host.FileName, host.ResolvePath);
host.log("compiler.emit complete");
var result = JSON.stringify({result: emitResult});
host.updateCompilerResult(result);
host.log("compiler.getSemanticDiagnostics start");
var diag = compiler.getSemanticDiagnostics(host.FileName);
var result2 = JSON.stringify({result: diag});
host.log("compiler.getSemanticDiagnostics complete");
host.log(result2);

//var diag2 = compiler.getSyntacticDiagnostics(host.FileName);
//var result3 = JSON.stringify({result: diag2});
//host.log("getSyntacticDiagnostics");
//host.log(result3);



