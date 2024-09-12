/**
 *
 * @param {string} src
 * @returns {void}
 */
function installScript(src) {
  const script = document.createElement("script");
  script.setAttribute("src", src);
  document.body.appendChild(script);
}

/**
 *
 * @param {string} src
 * @returns {void}
 */
function installCss(src) {
  const link = document.createElement("link");
  link.setAttribute("rel", "stylesheet");
  link.setAttribute("href", src);
  document.head.appendChild(link);
}

function startup() {
  installCss("_content/Radzen.Blazor/css/material-base.css");
  installScript("_content/Radzen.Blazor/Radzen.Blazor.js");
}

export function beforeStart() {
  startup();
}

export function beforeWebStart() {
  startup();
}
