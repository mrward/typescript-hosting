ls.refresh(true);
var sig = ls.getSignatureAtPosition(host.FileName, host.getPosition());
host.log(sig);