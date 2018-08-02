/******/ (function(modules) { // webpackBootstrap
/******/ 	// The module cache
/******/ 	var installedModules = {};
/******/
/******/ 	// The require function
/******/ 	function __webpack_require__(moduleId) {
/******/
/******/ 		// Check if module is in cache
/******/ 		if(installedModules[moduleId]) {
/******/ 			return installedModules[moduleId].exports;
/******/ 		}
/******/ 		// Create a new module (and put it into the cache)
/******/ 		var module = installedModules[moduleId] = {
/******/ 			i: moduleId,
/******/ 			l: false,
/******/ 			exports: {}
/******/ 		};
/******/
/******/ 		// Execute the module function
/******/ 		modules[moduleId].call(module.exports, module, module.exports, __webpack_require__);
/******/
/******/ 		// Flag the module as loaded
/******/ 		module.l = true;
/******/
/******/ 		// Return the exports of the module
/******/ 		return module.exports;
/******/ 	}
/******/
/******/
/******/ 	// expose the modules object (__webpack_modules__)
/******/ 	__webpack_require__.m = modules;
/******/
/******/ 	// expose the module cache
/******/ 	__webpack_require__.c = installedModules;
/******/
/******/ 	// define getter function for harmony exports
/******/ 	__webpack_require__.d = function(exports, name, getter) {
/******/ 		if(!__webpack_require__.o(exports, name)) {
/******/ 			Object.defineProperty(exports, name, { enumerable: true, get: getter });
/******/ 		}
/******/ 	};
/******/
/******/ 	// define __esModule on exports
/******/ 	__webpack_require__.r = function(exports) {
/******/ 		if(typeof Symbol !== 'undefined' && Symbol.toStringTag) {
/******/ 			Object.defineProperty(exports, Symbol.toStringTag, { value: 'Module' });
/******/ 		}
/******/ 		Object.defineProperty(exports, '__esModule', { value: true });
/******/ 	};
/******/
/******/ 	// create a fake namespace object
/******/ 	// mode & 1: value is a module id, require it
/******/ 	// mode & 2: merge all properties of value into the ns
/******/ 	// mode & 4: return value when already ns object
/******/ 	// mode & 8|1: behave like require
/******/ 	__webpack_require__.t = function(value, mode) {
/******/ 		if(mode & 1) value = __webpack_require__(value);
/******/ 		if(mode & 8) return value;
/******/ 		if((mode & 4) && typeof value === 'object' && value && value.__esModule) return value;
/******/ 		var ns = Object.create(null);
/******/ 		__webpack_require__.r(ns);
/******/ 		Object.defineProperty(ns, 'default', { enumerable: true, value: value });
/******/ 		if(mode & 2 && typeof value != 'string') for(var key in value) __webpack_require__.d(ns, key, function(key) { return value[key]; }.bind(null, key));
/******/ 		return ns;
/******/ 	};
/******/
/******/ 	// getDefaultExport function for compatibility with non-harmony modules
/******/ 	__webpack_require__.n = function(module) {
/******/ 		var getter = module && module.__esModule ?
/******/ 			function getDefault() { return module['default']; } :
/******/ 			function getModuleExports() { return module; };
/******/ 		__webpack_require__.d(getter, 'a', getter);
/******/ 		return getter;
/******/ 	};
/******/
/******/ 	// Object.prototype.hasOwnProperty.call
/******/ 	__webpack_require__.o = function(object, property) { return Object.prototype.hasOwnProperty.call(object, property); };
/******/
/******/ 	// __webpack_public_path__
/******/ 	__webpack_require__.p = "";
/******/
/******/
/******/ 	// Load entry module and return exports
/******/ 	return __webpack_require__(__webpack_require__.s = "./out/main.js");
/******/ })
/************************************************************************/
/******/ ({

/***/ "./out/ajax.js":
/*!*********************!*\
  !*** ./out/ajax.js ***!
  \*********************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";
eval("\r\n// by default, typescript leaves things in global scope.\r\n// but, any file with \"imports\" or \"exports\" statement in it\r\n// becomes a \"module\", and ONLY puts in global scope\r\n// what you EXPORT.\r\nObject.defineProperty(exports, \"__esModule\", { value: true });\r\nvar Ajax = /** @class */ (function () {\r\n    function Ajax() {\r\n    }\r\n    // in typescript, if you don't specify a type, it's \"any\" type.\r\n    // this works like \"dynamic\" in C#, and like everything in JS.\r\n    Ajax.prototype.send = function (url, method, success, fail) {\r\n        var xhr = new XMLHttpRequest();\r\n        xhr.addEventListener(\"load\", function (res) {\r\n            // this will run when the request completes\r\n            if (xhr.status >= 200 && xhr.status < 300) {\r\n                success(xhr.responseText);\r\n            }\r\n            else {\r\n                fail(xhr.statusText);\r\n            }\r\n        });\r\n        xhr.open(method, url);\r\n        xhr.send();\r\n    };\r\n    return Ajax;\r\n}());\r\nexports.Ajax = Ajax;\r\n\n\n//# sourceURL=webpack:///./out/ajax.js?");

/***/ }),

/***/ "./out/main.js":
/*!*********************!*\
  !*** ./out/main.js ***!
  \*********************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";
eval("\r\n// anything exported has to be imported to be used.\r\n// you import from a string which means the relative path\r\n// to that file where it's defined.\r\nObject.defineProperty(exports, \"__esModule\", { value: true });\r\n// when writing good typescript, every class should be in its own file,\r\n// and exported/imported. this is like namespaces/using in c#.\r\nvar ajax_1 = __webpack_require__(/*! ./ajax */ \"./out/ajax.js\");\r\nvar swcharacter_1 = __webpack_require__(/*! ./swcharacter */ \"./out/swcharacter.js\");\r\nvar Main = /** @class */ (function () {\r\n    function Main() {\r\n    }\r\n    // central addition of TypeScript:\r\n    // type annotations e.g. \": void\"\r\n    Main.Main = function () {\r\n        console.log(\"Hello world\");\r\n        var ajax = new ajax_1.Ajax();\r\n        // querySelector, another way to getElementById or by class, etc.\r\n        // in typescript, we cast like this: \"<newType> object\"\r\n        // or, with \"as\":\r\n        var btn = document.querySelector(\"#searchBtn\");\r\n        btn.addEventListener(\"click\", function () {\r\n            var list = document.querySelector(\"#searchList\");\r\n            var input = document.querySelector(\"#searchText\");\r\n            var searchText = input.value;\r\n            var url = \"https://swapi.co/api/people/?search=\" + searchText;\r\n            ajax.send(url, 'get', function (text) {\r\n                var result = JSON.parse(text);\r\n                list.innerHTML = \"\"; // empty the list\r\n                for (var i = 0; i < result.results.length; i++) {\r\n                    var char = new swcharacter_1.SWCharacter(result.results[i].name);\r\n                    var newItem = document.createElement(\"li\");\r\n                    newItem.innerHTML = char.description();\r\n                    list.appendChild(newItem);\r\n                }\r\n                ;\r\n            }, function (text) {\r\n                console.log(\"error: \" + text);\r\n            });\r\n        });\r\n    };\r\n    return Main;\r\n}());\r\n// TypeScript also adds classes, interfaces, inheritance,\r\n// access modifiers\r\nMain.Main();\r\n\n\n//# sourceURL=webpack:///./out/main.js?");

/***/ }),

/***/ "./out/swcharacter.js":
/*!****************************!*\
  !*** ./out/swcharacter.js ***!
  \****************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";
eval("\r\nObject.defineProperty(exports, \"__esModule\", { value: true });\r\nvar SWCharacter = /** @class */ (function () {\r\n    // shorthand syntax for having private \"name\" member,\r\n    // set from constructor\r\n    function SWCharacter(name) {\r\n        this.name = name;\r\n    }\r\n    SWCharacter.prototype.description = function () {\r\n        return \"Character named \" + this.name;\r\n    };\r\n    return SWCharacter;\r\n}());\r\nexports.SWCharacter = SWCharacter;\r\n\n\n//# sourceURL=webpack:///./out/swcharacter.js?");

/***/ })

/******/ });