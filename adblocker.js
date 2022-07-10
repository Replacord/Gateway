// Official Gateway Ad Blocker

let AdBlocker_Info = {

    Name: "No Ads here",
    CodeName:"Coffe",
    Version:"1.4"
    
}

console.log(`

AdBlocker_Info
AdBlocker_Name ${AdBlocker_Info.Name}
AdBlocker_CodeName ${AdBlocker_Info.CodeName}
AdBlocker_Version ${AdBlocker_Info.Version}
`)

for(let e=0;e<40;e++){
    lads=["sc-1i7jkv7-2","sc-1lqea4y-0"
    , "ytd-display-ad-renderer"
    , "ytd-promoted-sparkles-web-renderer"
    , "ytp-ad-image ytp-ad-action-interstitial-background"
    , "ytp-ad-module", "GoogleCreativeContainerClass"
    , "ytp-ad-image-overlay"
    , "ytp-ad-overlay-closed"
    , "ytd-action-companion-ad-renderer"
    , "ytd-action-companion-ad-renderer"
    , "ytd-action-companion-ad-renderer"
    , "ytd-promoted-sparkles-text-search-renderer", "darla", "my-adsLREC4"
    , "sb_add", "my-adsLREC3-fallback"
    ,"uEierd", "sb_rel_my-adsLREC3-iframe"]
    
    for(let i = 0; i < lads.length; i++){
    
        ads=document.getElementsByClassName(lads[i])
        for(let i = 0; i < ads.length; i++){
        console.log(ads[i])
        ads[i].remove(ads[i])
        }
        
    }}
