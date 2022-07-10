let Browser_Info = {

    Name: "GateWay",
    CodeName: "AppleSauce",
    Version: "2.4",
    Channel: "Release"
    
}

let GateName = Browser_Info.Name
let GateVersion = Browser_Info.Version
let GateChannel = Browser_Info.Channel

let AdBlocker_Info = {

    Name:"Mr. Overflow",
    codeName:"Banana",
    ver:"1.4"
    
}


function GetGateVar(key){

    if(localStorage.GateVars == undefined){
        localStorage.setItem("GateVars", '"VarDoesNotExist", "VarDoesNotExist", "client=",'+'"'+document.getElementById("Browser").attributes[1].value+'"'+',"version=",'+'"'+document.getElementById("Browser").attributes[2].value+'"'+',"channel=",'+'"'+document.getElementById("Browser").attributes[3].value+'"')
    }

    let vars=eval("["+localStorage.GateVars+"]")
    let val=vars[vars.indexOf(key+"=")+1]
    
    return val.toString().replace(key+"=")
}
function ChangeGateVar(key, value){

    vars=eval("["+localStorage.GateVars+"]")
    val=vars[vars.indexOf(key+"=")+1]
    val2=vars.indexOf(key+"=")+1
    vars[val2]=vars[val2].replace(val, value)
    for(let i = 0; i < vars.length; i++){
        console.log(i + 1)
        vars[i] = '"'+vars[i]+'"'
        localStorage.setItem("GateVars", vars)
    }
}
function AddGateVar(key ,value){

    if(localStorage.GateVars == undefined){
        localStorage.setItem("GateVars", '"VarDoesNotExist", "VarDoesNotExist", "client=",'+'"'+document.getElementById("Browser").attributes[1].value+'"'+',"version=",'+'"'+document.getElementById("Browser").attributes[2].value+'"'+',"channel=",'+'"'+document.getElementById("Browser").attributes[3].value+'"')
    }
    let vars=localStorage.GateVars
    localStorage.setItem("GateVars", vars+',"'+key+'="'+',"'+value+'"')
}

function KillGateVar(key){

    let vars=eval("["+localStorage.GateVars+"]")
    let val1=vars[vars.indexOf(key+"=")]
    let val2=vars[vars.indexOf(key+"=")+1]
    let val3=vars.indexOf(key+"=")
    let val4=vars.indexOf(key+"=")+1
    vars[val3] = vars[val3].replace(val1, "")
    vars[val4] = vars[val4].replace(val2, "")
    for(let i = 0; i < vars.length; i++){
        console.log(i + 1)
        vars[i] = '"'+vars[i]+'"'
        localStorage.setItem("GateVars", vars)
    }
    
}


function cObj(type, text, id){

let ele = document.createElement(type)
ele.innerText = text
ele.setAttribute("id", id)
document.body.append(ele)

}

function gObj(idorclass){


    let obj = document.querySelector(idorclass)
    return obj


}

function sEvent(obj, evnt, func){


    obj.addEventListener(evnt, func)


}
