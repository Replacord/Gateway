// Official Gateway Ad Blocker

// let AdBlocker_Info = {

//     Name: "No Ads here",
//     CodeName:"Coffe",
//     Version:"1.4"
    
// }

// console.log(`

// AdBlocker_Info
// AdBlocker_Name ${AdBlocker_Info.Name}
// AdBlocker_CodeName ${AdBlocker_Info.CodeName}
// AdBlocker_Version ${AdBlocker_Info.Version}
// `)

// for(let e=0;e<40;e++){
//     lads=["sc-1i7jkv7-2","sc-1lqea4y-0"
//     , "ytd-display-ad-renderer"
//     , "ytd-promoted-sparkles-web-renderer"
//     , "ytp-ad-image ytp-ad-action-interstitial-background"
//     , "ytp-ad-module", "GoogleCreativeContainerClass"
//     , "ytp-ad-image-overlay"
//     , "ytp-ad-overlay-closed"
//     , "ytd-action-companion-ad-renderer"
//     , "ytd-action-companion-ad-renderer"
//     , "ytd-action-companion-ad-renderer"
//     , "ytd-promoted-sparkles-text-search-renderer", "darla", "my-adsLREC4"
//     , "sb_add", "my-adsLREC3-fallback"
//     ,"uEierd", "sb_rel_my-adsLREC3-iframe"]
    
//     for(let i = 0; i < lads.length; i++){
    
//         ads=document.getElementsByClassName(lads[i])
//         for(let i = 0; i < ads.length; i++){
//         console.log(ads[i])
//         ads[i].remove(ads[i])
//         }
        
//     }}


let AdblockerConfig = {

    loop:true    

}
 
let PluginData_55770067919477794108674665223082153551612948461166614582140372007942350100513916589616287113937633482472454916732060539464763296975814436353173317761488943859491831172162775422040480279449={

    Name: "Ad Kill",
    Author:"Replacord Inc.",
    Version: "1.4.6",
    Loop: AdblockerConfig.loop

}

// Print Info
console.log(`

AdBlocker_Info
AdBlocker_Name ${PluginData_55770067919477794108674665223082153551612948461166614582140372007942350100513916589616287113937633482472454916732060539464763296975814436353173317761488943859491831172162775422040480279449.Name}
AdBlocker_Author: ${PluginData_55770067919477794108674665223082153551612948461166614582140372007942350100513916589616287113937633482472454916732060539464763296975814436353173317761488943859491831172162775422040480279449.Author}
AdBlocker_Version ${PluginData_55770067919477794108674665223082153551612948461166614582140372007942350100513916589616287113937633482472454916732060539464763296975814436353173317761488943859491831172162775422040480279449.Version}
AdBlocker_Using_Loop ${PluginData_55770067919477794108674665223082153551612948461166614582140372007942350100513916589616287113937633482472454916732060539464763296975814436353173317761488943859491831172162775422040480279449.Loop}

`)

// Main Code
function main_55770067919477794108674665223082153551612948461166614582140372007942350100513916589616287113937633482472454916732060539464763296975814436353173317761488943859491831172162775422040480279449(){

    for(let i = 0; i < 30; i++){
        lads=["sc-1i7jkv7-2","sc-1lqea4y-0"
        , "ytd-display-ad-renderer"
        , "ytd-promoted-sparkles-web-renderer"
        , "ytp-ad-image ytp-ad-action-interstitial-background"
        , "GoogleCreativeContainerClass"
        , "ytp-ad-image-overlay"
        , "ytd-action-companion-ad-renderer"
        , "ytd-promoted-sparkles-text-search-renderer", "darla", "my-adsLREC4"
        , "sb_add", "my-adsLREC3-fallback"
        ,"uEierd", "sb_rel_my-adsLREC3-iframe",
        "ytd-banner-promo-renderer", "ytd-banner-promo-renderer-background"]
        
        for(let i = 0; i < lads.length; i++){
        
            ads=document.getElementsByClassName(lads[i])
            for(let i = 0; i < ads.length; i++){
            console.log(ads[i])
            ads[i].remove(ads[i])
            }
            
        }
    }
}

// Run Plugin

main_55770067919477794108674665223082153551612948461166614582140372007942350100513916589616287113937633482472454916732060539464763296975814436353173317761488943859491831172162775422040480279449()

var timerID;
timerID = window.setInterval(main_55770067919477794108674665223082153551612948461166614582140372007942350100513916589616287113937633482472454916732060539464763296975814436353173317761488943859491831172162775422040480279449, 100);
