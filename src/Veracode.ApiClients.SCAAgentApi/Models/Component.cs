// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracode.ApiClients.SCAAgentApi.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Component Object
    /// </summary>
    public partial class Component
    {
        /// <summary>
        /// Initializes a new instance of the Component class.
        /// </summary>
        public Component()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Component class.
        /// </summary>
        /// <param name="type">Specifies the type of component. For software
        /// components, classify as application if no more specific appropriate
        /// classification is available or cannot be determined for the
        /// component. Types include:
        ///
        /// * __application__ = A software application. Refer to
        /// [https://en.wikipedia.org/wiki/Application_software](https://en.wikipedia.org/wiki/Application_software)
        /// for information about applications.
        /// * __framework__ = A software framework. Refer to
        /// [https://en.wikipedia.org/wiki/Software_framework](https://en.wikipedia.org/wiki/Software_framework)
        /// for information on how frameworks vary slightly from libraries.
        /// * __library__ = A software library. Refer to
        /// [https://en.wikipedia.org/wiki/Library_(computing)](https://en.wikipedia.org/wiki/Library_(computing))
        /// for information about libraries. All third-party and open source
        /// reusable components are likely libraries. If the library also has
        /// key features of a framework, then it should be classified as a
        /// framework. If not, or if it is unknown, then Veracode recommends
        /// classifying as a library.
        /// * __container__ = A packaging and/or runtime format, not specific
        /// to any particular technology, which isolates software inside the
        /// container from software outside of a container through
        /// virtualization technology. Refer to
        /// [https://en.wikipedia.org/wiki/OS-level_virtualization](https://en.wikipedia.org/wiki/OS-level_virtualization)
        /// * __operating-system__ = A software operating system without regard
        /// to deployment model (i.e. installed on physical hardware, virtual
        /// machine, image, etc) Refer to
        /// [https://en.wikipedia.org/wiki/Operating_system](https://en.wikipedia.org/wiki/Operating_system)
        /// * __device__ = A hardware device such as a processor or chipset. A
        /// hardware device containing firmware should include a component for
        /// the physical hardware itself, and another component of type
        /// 'firmware' or 'operating-system' (whichever is relevant),
        /// describing information about the software running on the device.
        /// * __firmware__ = A special type of software that provides low-level
        /// control over a devices hardware. Refer to
        /// [https://en.wikipedia.org/wiki/Firmware](https://en.wikipedia.org/wiki/Firmware)
        /// * __file__ = A computer file. Refer to
        /// [https://en.wikipedia.org/wiki/Computer_file](https://en.wikipedia.org/wiki/Computer_file)
        /// for information about files. Possible values include:
        /// 'application', 'library'</param>
        /// <param name="name">The name of the component. This often is a
        /// shortened, single name of the component. Examples include:
        /// commons-lang3 and jquery</param>
        /// <param name="bomRef">BOM Reference</param>
        /// <param name="supplier">Component Supplier</param>
        /// <param name="group">The grouping name or identifier. This often is
        /// a shortened, single name of the company or project that produced
        /// the component, or the source package or domain name. Do not use
        /// whitespace or special characters. Examples include: apache,
        /// org.apache.commons, and apache.org.</param>
        /// <param name="version">The component version. The version should
        /// comply with semantic versioning.</param>
        /// <param name="purl">Specifies the package-url (purl). The purl, if
        /// specified, MUST be valid and conform to the specification defined
        /// at:
        /// [https://github.com/package-url/purl-spec](https://github.com/package-url/purl-spec)</param>
        /// <param name="properties">Provides the ability to document
        /// properties in a name-value store. This provides flexibility to
        /// include data not officially supported in the standard without
        /// having to use additional namespaces or create extensions. Unlike
        /// key-value stores, properties support duplicate names, each
        /// potentially having different values. Property names of interest to
        /// the general public are encouraged to be registered in the
        /// [CycloneDX Property
        /// Taxonomy](https://github.com/CycloneDX/cyclonedx-property-taxonomy).
        /// Formal registration is optional.</param>
        public Component(string type, string name, string bomRef = default(string), OrganizationalEntity supplier = default(OrganizationalEntity), string group = default(string), string version = default(string), IList<Hash> hashes = default(IList<Hash>), IList<LicenseChoice> licenses = default(IList<LicenseChoice>), string purl = default(string), IList<Property> properties = default(IList<Property>))
        {
            Type = type;
            BomRef = bomRef;
            Supplier = supplier;
            Group = group;
            Name = name;
            Version = version;
            Hashes = hashes;
            Licenses = licenses;
            Purl = purl;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the type of component. For software
        /// components, classify as application if no more specific appropriate
        /// classification is available or cannot be determined for the
        /// component. Types include:
        ///
        /// * __application__ = A software application. Refer to
        /// [https://en.wikipedia.org/wiki/Application_software](https://en.wikipedia.org/wiki/Application_software)
        /// for information about applications.
        /// * __framework__ = A software framework. Refer to
        /// [https://en.wikipedia.org/wiki/Software_framework](https://en.wikipedia.org/wiki/Software_framework)
        /// for information on how frameworks vary slightly from libraries.
        /// * __library__ = A software library. Refer to
        /// [https://en.wikipedia.org/wiki/Library_(computing)](https://en.wikipedia.org/wiki/Library_(computing))
        /// for information about libraries. All third-party and open source
        /// reusable components are likely libraries. If the library also has
        /// key features of a framework, then it should be classified as a
        /// framework. If not, or if it is unknown, then Veracode recommends
        /// classifying as a library.
        /// * __container__ = A packaging and/or runtime format, not specific
        /// to any particular technology, which isolates software inside the
        /// container from software outside of a container through
        /// virtualization technology. Refer to
        /// [https://en.wikipedia.org/wiki/OS-level_virtualization](https://en.wikipedia.org/wiki/OS-level_virtualization)
        /// * __operating-system__ = A software operating system without regard
        /// to deployment model (i.e. installed on physical hardware, virtual
        /// machine, image, etc) Refer to
        /// [https://en.wikipedia.org/wiki/Operating_system](https://en.wikipedia.org/wiki/Operating_system)
        /// * __device__ = A hardware device such as a processor or chipset. A
        /// hardware device containing firmware should include a component for
        /// the physical hardware itself, and another component of type
        /// 'firmware' or 'operating-system' (whichever is relevant),
        /// describing information about the software running on the device.
        /// * __firmware__ = A special type of software that provides low-level
        /// control over a devices hardware. Refer to
        /// [https://en.wikipedia.org/wiki/Firmware](https://en.wikipedia.org/wiki/Firmware)
        /// * __file__ = A computer file. Refer to
        /// [https://en.wikipedia.org/wiki/Computer_file](https://en.wikipedia.org/wiki/Computer_file)
        /// for information about files. Possible values include:
        /// 'application', 'library'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets BOM Reference
        /// </summary>
        /// <remarks>
        /// An optional identifier, which can be used to reference the
        /// component elsewhere in the BOM. Every bom-ref MUST be unique within
        /// the BOM.
        /// </remarks>
        [JsonProperty(PropertyName = "bom-ref")]
        public string BomRef { get; set; }

        /// <summary>
        /// Gets or sets component Supplier
        /// </summary>
        /// <remarks>
        /// The organization that supplied the component. The supplier is often
        /// the manufacturer, but may also be a distributor or repackager.
        /// </remarks>
        [JsonProperty(PropertyName = "supplier")]
        public OrganizationalEntity Supplier { get; set; }

        /// <summary>
        /// Gets or sets the grouping name or identifier. This often is a
        /// shortened, single name of the company or project that produced the
        /// component, or the source package or domain name. Do not use
        /// whitespace or special characters. Examples include: apache,
        /// org.apache.commons, and apache.org.
        /// </summary>
        [JsonProperty(PropertyName = "group")]
        public string Group { get; set; }

        /// <summary>
        /// Gets or sets the name of the component. This often is a shortened,
        /// single name of the component. Examples include: commons-lang3 and
        /// jquery
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the component version. The version should comply with
        /// semantic versioning.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "hashes")]
        public IList<Hash> Hashes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "licenses")]
        public IList<LicenseChoice> Licenses { get; set; }

        /// <summary>
        /// Gets or sets specifies the package-url (purl). The purl, if
        /// specified, MUST be valid and conform to the specification defined
        /// at:
        /// [https://github.com/package-url/purl-spec](https://github.com/package-url/purl-spec)
        /// </summary>
        [JsonProperty(PropertyName = "purl")]
        public string Purl { get; set; }

        /// <summary>
        /// Gets or sets provides the ability to document properties in a
        /// name-value store. This provides flexibility to include data not
        /// officially supported in the standard without having to use
        /// additional namespaces or create extensions. Unlike key-value
        /// stores, properties support duplicate names, each potentially having
        /// different values. Property names of interest to the general public
        /// are encouraged to be registered in the [CycloneDX Property
        /// Taxonomy](https://github.com/CycloneDX/cyclonedx-property-taxonomy).
        /// Formal registration is optional.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IList<Property> Properties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Hashes != null)
            {
                foreach (var element in Hashes)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
